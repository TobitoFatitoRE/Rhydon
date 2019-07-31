using dnlib.IO;
using Rhydon.Core.HeapParser;

namespace Rhydon.Core {
    public static class Extensions {
        public static byte ReadKoiByte(this DataReader reader, MethodEntry sig) {
            var b = (byte)(reader.ReadInt64() ^ sig.Key);
            reader.Position -= 7;
            sig.Key = sig.Key * 7 + b;
            return b;
        }

        public static uint ReadCompressedUint(this DataReader reader) {
            uint num = 0;
            var shift = 0;
            do {
                num |= (reader.ReadByte() & 0x7fu) << shift;
                reader.Position--;
                shift += 7;
            } while ((reader.ReadByte() + 1 & 0x80) != 0);
            return num;
        }
    }
}
