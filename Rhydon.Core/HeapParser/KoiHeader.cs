using System.Collections.Generic;
using System.Linq;
using System.Text;
using dnlib.DotNet;

namespace Rhydon.Core.HeapParser {
    public class KoiHeader {
        public KoiHeader(RhydonContext ctx) {
            ctx.Logger.Debug("Looking for #Koi stream...");
            var heap = ctx.Module.Metadata.AllStreams.SingleOrDefault(s => s.Name == "#Koi");
            if (heap == null)
                return;

            ctx.Logger.Info("Parsing KoiVM header");
            ctx.HeapReader = heap.CreateReader();
            var reader = ctx.HeapReader;

            var magic = reader.ReadUInt32();
            if (magic != 0x68736966)
                ctx.Logger.Warning($"Magic wasn't 'fish' (0x68736966), instead: 0x{magic:X}");

            var refCount = (int)reader.ReadUInt32();
            var strCount = (int)reader.ReadUInt32();
            var metCount = (int)reader.ReadUInt32();

            References = new Dictionary<uint, IMemberRef>(refCount);
            Strings = new Dictionary<uint, string>(strCount);
            Methods = new Dictionary<uint, MethodEntry>(metCount);

            ReadReferences(ctx, refCount);
            ctx.Logger.Success($"Parsed {refCount} references");

            ReadStrings(ctx, strCount);
            ctx.Logger.Success($"Parsed {strCount} strings");

            ReadMethods(ctx, metCount);
            ctx.Logger.Success($"Parsed {metCount} exports");

            Good = true;
        }

        void ReadReferences(RhydonContext ctx, int count) {
            var reader = ctx.HeapReader;
            for (var i = 0; i < count; i++) {
                var id = reader.ReadCompressedUint();
                var token = FromCodedToken(reader.ReadCompressedUint());
                var resolved = (IMemberRef)ctx.Module.ResolveToken(token);

                ctx.Logger.Debug($"Reference[{id:D3}]: Token: 0x{token:X} | MemberRef: {resolved.FullName}");
                References[id] = resolved;
            }
        }

        void ReadStrings(RhydonContext ctx, int count) {
            var reader = ctx.HeapReader;
            for (var i = 0; i < count; i++) {
                var id = reader.ReadCompressedUint();
                var len = (int)reader.ReadCompressedUint() << 1;
                var str = Encoding.Unicode.GetString(reader.ReadBytes(len));

                ctx.Logger.Debug($"Strings[{id:D3}]: \"{str}\"");
                Strings[id] = str;
            }
        }

        void ReadMethods(RhydonContext ctx, int count) {
            var reader = ctx.HeapReader;
            for (var i = 0; i < count; i++) {
                var id = reader.ReadCompressedUint();
                var export = MethodEntry.Create(ctx);

                ctx.Logger.Debug($"Methods[{id:D3}]: Offset: 0x{export.Offset:X8} Key: 0x{export.Key:X8}");
                Methods[id] = export;
            }
        }

        public bool Good { get; }

        public readonly Dictionary<uint, IMemberRef> References;
        public readonly Dictionary<uint, string> Strings;
        public readonly Dictionary<uint, MethodEntry> Methods;

        public static uint FromCodedToken(uint codedToken) {
            var rid = codedToken >> 3;
            switch (codedToken & 7) {
                case 1:
                    return rid | 0x02000000;
                case 2:
                    return rid | 0x01000000;
                case 3:
                    return rid | 0x1b000000;
                case 4:
                    return rid | 0x0a000000;
                case 5:
                    return rid | 0x06000000;
                case 6:
                    return rid | 0x04000000;
                case 7:
                    return rid | 0x2b000000;
                default:
                    return rid;
            }
        }
    }
}
