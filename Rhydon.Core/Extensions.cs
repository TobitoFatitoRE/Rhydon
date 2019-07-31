using dnlib.IO;
using Rhydon.Core.HeapParser;

namespace Rhydon.Core {
    public static class Extensions {
        public static byte ReadKoiByte(this DataReader reader, MethodSig sig) {
            var b = (byte)(reader.ReadInt64() ^ sig.Key);
            sig.Key = sig.Key * 7 + b;
            return b;
        }
    }
}
