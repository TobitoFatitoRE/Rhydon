using dnlib.DotNet;

namespace Rhydon.Core.HeapParser {
    public class MethodEntry {
        internal static MethodEntry Create(RhydonContext ctx) {
            var reader = ctx.HeapReader;
            var obj = new MethodEntry { Offset = reader.ReadUInt32() };
            if (obj.Offset != 0) {
                obj.Key = reader.ReadUInt32();
            }

            obj.Flags = reader.ReadByte();

            obj.ArgumentTypes = new ITypeDefOrRef[reader.ReadCompressedUint()];
            for (var i = 0; i < obj.ArgumentTypes.Length; i++)
                obj.ArgumentTypes[i] = (ITypeDefOrRef)ctx.Module.ResolveToken(KoiHeader.FromCodedToken(reader.ReadCompressedUint()));

            obj.ReturnType = (ITypeDefOrRef)ctx.Module.ResolveToken(KoiHeader.FromCodedToken(reader.ReadCompressedUint()));
            return obj;
        }

        public uint Offset;
        public uint Key;
        public byte Flags;
        public ITypeDefOrRef[] ArgumentTypes;
        public ITypeDefOrRef ReturnType;
    }
}
