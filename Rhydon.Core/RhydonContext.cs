using dnlib.DotNet;
using dnlib.IO;
using Rhydon.Core.HeapParser;

namespace Rhydon.Core {
    public class RhydonContext {
        public ModuleDefMD Module { get; set; }
        public DataReader HeapReader { get; set; }
        public KoiHeader Header { get; set; }
    }
}
