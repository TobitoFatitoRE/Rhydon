using System;

namespace Rhydon.Emulator.Handlers.VCall {
    class Cast : VCallHandler {
        public Cast(EmuContext ctx) : base(ctx) { }

        internal override byte VCall => Ctx.Constants.VCALL_CAST;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot slot = ctx.Stack.Pop();
            VMSlot value = ctx.Stack.Pop();
            bool flag = (slot.U4 & 2147483648u) > 0u;
            Type type = (Type)ctx.Header.References[slot.U4 & 2147483647u];
            bool flag2 = Type.GetTypeCode(type) == TypeCode.String && value.O == null;
            if(flag2) {
                value.O = ctx.Header.Strings[value.U4];
            } else {
                if(value.O == null) {
                    value.O = null;
                    //nigga wtf
                } else {
                    if(!type.IsInstanceOfType(value.O)) {
                        value.O = null;
                        if(flag) {
                            //throw exceptpion
                        }
                    }
                }
            }
            ctx.Stack.Push(value);
        }
    }
}
