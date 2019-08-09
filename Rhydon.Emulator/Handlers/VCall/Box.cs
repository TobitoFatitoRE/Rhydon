using System;

namespace Rhydon.Emulator.Handlers.VCall {
    class Box : VCallHandler {
        public Box(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_BOX;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot slot = ctx.Stack.Pop();
            VMSlot value = ctx.Stack.Pop();
            Type type = (Type)ctx.Header.References[slot.U4];
            if(Type.GetTypeCode(type) == TypeCode.String && value.O == null) {
                value.O = ctx.Header.Strings[value.U4];
            } else {
                value.O = value.ToObject(type);
            }
            ctx.Stack.Push(value);
        }
    }
}
