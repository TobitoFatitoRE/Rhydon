using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using dnlib.DotNet;

namespace Rhydon.Core.Parser {
    public class KoiHeader {
        public KoiHeader(RhydonContext ctx) {
            ctx.Logger.Debug("Looking for #Koi stream...");
            var heap = ctx.Module.Metadata.AllStreams.SingleOrDefault(s => s.Name == "#Koi");
            if (heap == null) {
                ctx.Logger.Error("#Koi stream not found...");
                return;
            }

            ctx.Logger.Info("Parsing KoiVM header");
            ctx.Reader = new BinaryReader(heap.CreateReader().AsStream());

            var magic = ctx.ReadUInt32();
            if (magic != 0x68736966)
                ctx.Logger.Warning($"Magic wasn't 'fish' (0x68736966), instead: 0x{magic:X}");

            var refCount = (int)ctx.ReadUInt32();
            var strCount = (int)ctx.ReadUInt32();
            var metCount = (int)ctx.ReadUInt32();

            References = new Dictionary<uint, IMemberRef>(refCount);
            Strings = new Dictionary<uint, string>(strCount);
            Methods = new Dictionary<uint, MethodExport>(metCount);

            ReadReferences(ctx, refCount);
            ctx.Logger.Success($"Parsed {refCount} references");

            ReadStrings(ctx, strCount);
            ctx.Logger.Success($"Parsed {strCount} strings");

            ReadMethods(ctx, metCount);
            ctx.Logger.Success($"Parsed {metCount} exports");

            Good = true;
        }

        void ReadReferences(RhydonContext ctx, int count) {
            for (var i = 0; i < count; i++) {
                var id = ctx.ReadCompressedUint();
                var token = FromCodedToken(ctx.ReadCompressedUint());
                var resolved = (IMemberRef)ctx.Module.ResolveToken(token);

                ctx.Logger.Debug($"Reference[{id:D3}]: Token: 0x{token:X} | MemberRef: {resolved.FullName}");
                References[id] = resolved;
            }
        }

        void ReadStrings(RhydonContext ctx, int count) {
            for (var i = 0; i < count; i++) {
                var id = ctx.ReadCompressedUint();
                var len = (int)ctx.ReadCompressedUint() << 1;
                var str = Encoding.Unicode.GetString(ctx.ReadBytes(len));

                ctx.Logger.Debug($"Strings[{id:D3}]: \"{str}\"");
                Strings[id] = str;
            }
        }

        void ReadMethods(RhydonContext ctx, int count) {
            for (var i = 0; i < count; i++) {
                var id = ctx.ReadCompressedUint();
                var export = MethodExport.Create(ctx);

                ctx.Logger.Debug($"Methods[{id:D3}]: Offset: 0x{export.Offset:X8} Key: 0x{export.Key:X8}");
                Methods[id] = export;
            }
        }

        public bool Good { get; }

        public readonly Dictionary<uint, IMemberRef> References;
        public readonly Dictionary<uint, string> Strings;
        public readonly Dictionary<uint, MethodExport> Methods;

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

    public class MethodExport {
        public static MethodExport Create(RhydonContext ctx) {
            var obj = new MethodExport() { Offset = ctx.Reader.ReadUInt32() };
            if (obj.Offset != 0) {
                obj.Key = ctx.Reader.ReadUInt32();
            }

            obj.Flags = ctx.Reader.ReadByte();

            obj.ArgumentTypes = new ITypeDefOrRef[ctx.Reader.ReadCompressedUint()];
            for (var i = 0; i < obj.ArgumentTypes.Length; i++)
                obj.ArgumentTypes[i] = (ITypeDefOrRef)ctx.Module.ResolveToken(KoiHeader.FromCodedToken(ctx.Reader.ReadCompressedUint()));

            obj.ReturnType = (ITypeDefOrRef)ctx.Module.ResolveToken(KoiHeader.FromCodedToken(ctx.Reader.ReadCompressedUint()));
            return obj;
        }

        public uint Offset;
        public uint Key;
        public byte Flags;
        public ITypeDefOrRef[] ArgumentTypes;
        public ITypeDefOrRef ReturnType;
    }
}
