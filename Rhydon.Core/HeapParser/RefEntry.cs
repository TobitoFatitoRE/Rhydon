using dnlib.DotNet;

namespace Rhydon.Core.HeapParser {
    public class RefEntry {
        public RefEntry(uint id, IMemberRef reference) {
            Id = id;
            Reference = reference;
        }

        public uint Id { get; }
        public IMemberRef Reference { get; }
    }
}
