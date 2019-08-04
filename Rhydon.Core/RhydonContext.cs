using System.Collections.Generic;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Rhydon.Core.Parser;

namespace Rhydon.Core {
    public class RhydonContext {
        public RhydonContext() {
            Decompiled = new Dictionary<uint, CilBody>();
            Parameters = new OptionalParameters();
        }

        public ModuleDefMD Module { get; set; }
        public BinaryReader Reader { get; set; }
        public KoiHeader Header { get; set; }
        public uint StartOffset { get; set; }
        public Constants Constants { get; set; }
        public Dictionary<uint, CilBody> Decompiled { get; set; }
        public ILogger Logger { get; set; }
        public OptionalParameters Parameters { get; set; }
        
        public byte[] ReadBytes(int len) =>
            Reader.ReadBytes(len);

        public uint ReadUInt32() =>
            Reader.ReadUInt32();

        public uint ReadCompressedUint() =>
            Reader.ReadCompressedUint();
    }
}
