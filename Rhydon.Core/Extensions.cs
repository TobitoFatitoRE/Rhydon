using System.IO;
using Rhydon.Core.Parser;

namespace Rhydon.Core {
    public static class Extensions {
        public static byte ReadKoiByte(this BinaryReader reader, MethodExport sig) {
            var b = (byte)(reader.ReadInt64() ^ sig.Key);
            reader.BaseStream.Position -= 7;
            sig.Key = sig.Key * 7 + b;
            return b;
        }

        public static uint ReadCompressedUint(this BinaryReader reader) {
            uint num = 0;
            var shift = 0;
            do {
                num |= (reader.ReadByte() & 0x7fu) << shift;
                reader.BaseStream.Position--;
                shift += 7;
            } while ((reader.ReadByte() + 1 & 0x80) != 0);
            return num;
        }
    }
}
