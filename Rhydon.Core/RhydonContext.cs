using System.Collections.Generic;
using System.IO;
using dnlib.DotNet;
using Rhydon.Core.Parser;

namespace Rhydon.Core {
    public class RhydonContext {
        public ModuleDefMD Module { get; set; }
        public BinaryReader Reader { get; set; }
        public KoiHeader Header { get; set; }
        public Dictionary<byte, KoiOpCodes> Map { get; set; }
        public ILogger Logger { get; set; }
        
        public byte[] ReadBytes(int len) =>
            Reader.ReadBytes(len);

        public uint ReadUInt32() =>
            Reader.ReadUInt32();

        public byte ReadKoi(MethodEntry export) =>
            Reader.ReadKoiByte(export);

        public uint ReadCompressedUint() =>
            Reader.ReadCompressedUint();
    }
}
