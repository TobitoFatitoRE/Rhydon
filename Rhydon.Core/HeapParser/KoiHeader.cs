using System.Collections.Generic;
using System.Linq;

namespace Rhydon.Core.HeapParser {
    public class KoiHeader {
        public KoiHeader(RhydonContext ctx) {
            var heap = ctx.Module.Metadata.AllStreams.SingleOrDefault(s => s.Name == "#Koi");
            if (heap == null)
                return;

            ctx.HeapReader = heap.CreateReader();
            var reader = ctx.HeapReader;

            References = new Dictionary<uint, RefEntry>((int)reader.ReadUInt32());
            Strings = new Dictionary<uint, StringEntry>((int)reader.ReadUInt32());
            Methods = new Dictionary<uint, MethodEntry>((int)reader.ReadUInt32());

            Good = true;
        }

        public bool Good;

        public Dictionary<uint, RefEntry> References;
        public Dictionary<uint, StringEntry> Strings;
        public Dictionary<uint, MethodEntry> Methods;
    }
}
