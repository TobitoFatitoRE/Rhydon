using System;
using System.Reflection;
namespace Rhydon.Emulator.Handlers.VCall {
    class Stfld : VCallHandler {
        public Stfld(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_STFLD;
        internal unsafe override void EmulateVCall(EmuContext ctx) {
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            VMSlot slot3 = ctx.Stack.Pop();

            FieldInfo fieldInfo = (FieldInfo)ctx.Header.References[slot.U4];
            bool flag = !fieldInfo.IsStatic && slot3.O == null;
            if (flag) {
                throw new NullReferenceException();
            }
            bool flag2 = Type.GetTypeCode(fieldInfo.FieldType) == TypeCode.String && slot2.O == null;
            object value;
            if (flag2) {
                value = ctx.Header.Strings[slot2.U4];
            } else {
                value = slot2.ToObject(fieldInfo.FieldType);
            }
            bool flag3 = fieldInfo.DeclaringType.IsValueType && slot3.O is IReference;
            if (flag3) {
                TypedReference obj;
                ((IReference)slot3.O).ToTypedReference(ctx, (void*)(&obj), fieldInfo.DeclaringType);
                Rhydon.Emulator.Helpers.TypedReferenceHelpers.CastTypedRef((void*)(&obj), fieldInfo.DeclaringType);
                fieldInfo.SetValueDirect(obj, value);
            } else {
                fieldInfo.SetValue(slot3.ToObject(fieldInfo.DeclaringType), value);
            }
        }
    }
}
