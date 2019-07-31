using dnlib.DotNet;

namespace Rhydon.Core.HeapParser {
    public class MethodEntry {
        public static MethodEntry Create(RhydonContext ctx) {
            var obj = new MethodEntry { Offset = ctx.Reader.ReadUInt32() };
            if (obj.Offset != 0) {
                obj.Key = ctx.Reader.ReadUInt32();
            }

            obj.Flags = ctx.Reader.ReadByte();

            obj.ArgumentTypes = new ITypeDefOrRef[ctx.Reader.ReadCompressedUint()];
            for (var i = 0; i < obj.ArgumentTypes.Length; i++)
                obj.ArgumentTypes[i] = (ITypeDefOrRef)ctx.Module.ResolveToken(KoiHeader.FromCodedToken(ctx.Reader.ReadCompressedUint()));

            obj.ReturnType = (ITypeDefOrRef)ctx.Module.ResolveToken(KoiHeader.FromCodedToken(ctx.Reader.ReadCompressedUint()));
            return obj;
        }

        public uint Offset;
        public uint Key;
        public byte Flags;
        public ITypeDefOrRef[] ArgumentTypes;
        public ITypeDefOrRef ReturnType;
    }
}
