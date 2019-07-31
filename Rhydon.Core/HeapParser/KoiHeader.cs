using System.Collections.Generic;
using dnlib.DotNet;

namespace Rhydon.Core.HeapParser {
    public class KoiHeader {
        public KoiHeader(ModuleDefMD module) {
            References = new Dictionary<uint, RefEntry>();
            Strings = new Dictionary<uint, StringEntry>();
        }

        public readonly Dictionary<uint, RefEntry> References;
        public readonly Dictionary<uint, StringEntry> Strings;
    }
}
