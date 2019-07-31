namespace Rhydon.Core.HeapParser {
    public class StringEntry {
        public StringEntry(uint id, string str) {
            Id = id;
            Value = str;
        }

        public uint Id { get; }
        public string Value { get; }
    }
}
