using System.Collections.Generic;
using System.Linq;
using System.Text;
using dnlib.DotNet;

namespace Rhydon.Core.HeapParser {
    public class KoiHeader {
        public KoiHeader(RhydonContext ctx) {
            var heap = ctx.Module.Metadata.AllStreams.SingleOrDefault(s => s.Name == "#Koi");
            if (heap == null)
                return;

            ctx.HeapReader = heap.CreateReader();
            var reader = ctx.HeapReader;

            var magic = reader.ReadUInt32();
            //0x68736966

            var refCount = (int)reader.ReadUInt32();
            var strCount = (int)reader.ReadUInt32();
            var metCount = (int)reader.ReadUInt32();

            References = new Dictionary<uint, IMemberRef>(refCount);
            Strings = new Dictionary<uint, string>(strCount);
            Methods = new Dictionary<uint, MethodEntry>(metCount);

            ReadReferences(ctx, refCount);
            ReadStrings(ctx, strCount);
            ReadMethods(ctx, metCount);

            Good = true;
        }

        void ReadReferences(RhydonContext ctx, int count) {
            var reader = ctx.HeapReader;
            for (var i = 0; i < References.Count; i++) {
                var id = reader.ReadCompressedUint();
                var token = FromCodedToken(reader.ReadCompressedUint());
                var resolved = (IMemberRef)ctx.Module.ResolveToken(token);

                References[id] = resolved;
            }
        }

        void ReadStrings(RhydonContext ctx, int count) {
            var reader = ctx.HeapReader;
            for (var i = 0; i < Strings.Count; i++) {
                var id = reader.ReadCompressedUint();
                var len = (int)reader.ReadCompressedUint() << 1;
                var str = Encoding.Unicode.GetString(reader.ReadBytes(len));

                Strings[id] = str;
            }
        }

        void ReadMethods(RhydonContext ctx, int count) {
            var reader = ctx.HeapReader;
            for (var i = 0; i < Methods.Count; i++) {
                var id = reader.ReadCompressedUint();

                //TODO: Finish this
                Methods[id] = new MethodEntry();
            }
        }

        public bool Good { get; }

        public Dictionary<uint, IMemberRef> References;
        public Dictionary<uint, string> Strings;
        public Dictionary<uint, MethodEntry> Methods;

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
