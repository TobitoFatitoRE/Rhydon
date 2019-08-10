using System.Reflection;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ldfld : VCallHandler {
        public Ldfld(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_LDFLD;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            bool flag = (slot.U4 & 2147483648u) > 0u;
            FieldInfo fieldInfo = (FieldInfo)ctx.Header.References[slot.U4 & 2147483647u];
            bool flag2 = !fieldInfo.IsStatic && slot2.O == null;
            if (flag2) {
                // throw new NullReferenceException();
                return;
            }
            if(flag) {
                ctx.Stack.Push(new VMSlot() { O = new FieldRef(slot2.O, fieldInfo) });
            } else {
                bool flag4 = fieldInfo.DeclaringType.IsValueType && slot2.O is IReference;
                object obj;
                if (flag4) {
                    obj = ((IReference)slot2.O).GetValue(ctx, PointerType.OBJECT).ToObject(fieldInfo.DeclaringType);
                } else {
                    obj = slot2.ToObject(fieldInfo.DeclaringType);
                }
                ctx.Stack.Push(VMSlot.FromObject(fieldInfo.GetValue(obj), fieldInfo.FieldType));
            }
        }
    }
}
