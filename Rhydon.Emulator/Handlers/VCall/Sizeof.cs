using System;
namespace Rhydon.Emulator.Handlers.VCall {
    class Sizeof : VCallHandler {
        public Sizeof(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_SIZEOF;
        internal override void EmulateVCall(EmuContext ctx) {
            Type type = (Type)ctx.Header.References[ctx.Stack.Pop().U4];
            ctx.Stack.Push(new VMSlot() { U4 = (uint)SizeOfHelper.SizeOf(type) });
            //TO FIX SIZEOFHELPER!!!!
        }
    }
}
