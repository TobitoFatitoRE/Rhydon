using System;
namespace Rhydon.Emulator.Handlers.VCall {
    class Unbox : VCallHandler {
        public Unbox(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_UNBOX;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot slot = ctx.Stack.Pop();
            VMSlot value = ctx.Stack.Pop();
            bool flag = (slot.U4 & 2147483648u) > 0u;
            Type type = (Type)ctx.Header.References[slot.U4 & 2147483647u];
            if(flag) {
                TypedReference typedRef;
             //   TypedReferenceHelpers.UnboxTypedRef(value.O, (void*)(&typedRef));
              //  TypedRef typedRef2 = new TypedRef(typedRef);
              //todo TypedRef,TypedReferenceHelper
                value = VMSlot.FromObject(value.O, type);
                ctx.Stack.Push(value);
            } else {
                bool flag3 = type == typeof(object) && value.O != null;
                if (flag3) {
                    type = value.O.GetType();
                }
                value = VMSlot.FromObject(value.O, type);
                ctx.Stack.Push(value);
            }

        }
        
    }
}
