using System;
using System.Runtime.Serialization;

namespace Rhydon.Emulator.Handlers.VCall {
    class Initobj : VCallHandler {
        public Initobj(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_INITOBJ;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            Type type = (Type)ctx.Header.References[slot.U4];
            bool flag = slot2.O is IReference;
            if (flag) {
                IReference reference = (IReference)slot2.O;
                VMSlot val = new VMSlot();
                bool isValueType = type.IsValueType;
                if (isValueType) {
                    object vt = null;
                    bool flag2 = Nullable.GetUnderlyingType(type) == null;
                    if (flag2) {
                        vt = FormatterServices.GetUninitializedObject(type);
                    }
                    slot.O = Box(vt, type);
                } else {
                    slot.O = null;
                }
            }
        }
        public static IValueTypeBox Box(object vt, Type vtType) {
            Type type = typeof(ValueTypeBox<>).MakeGenericType(new Type[]
            {
                vtType
            });
            return (IValueTypeBox)Activator.CreateInstance(type, new object[]
            {
                vt
            });
        }
    }
}
