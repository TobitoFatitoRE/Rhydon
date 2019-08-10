using System;
using System.Reflection;
namespace Rhydon.Emulator.Handlers.VCall {
    class Token : VCallHandler {
        public Token(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_TOKEN;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot value = ctx.Stack.Pop();
            MemberInfo memberInfo = (MemberInfo)ctx.Header.References[value.U4];
            bool flag = memberInfo is Type;
            if (flag) {
                value.O = ValueTypeBox.Box(((Type)memberInfo).TypeHandle, typeof(RuntimeTypeHandle));
            } else {
                bool flag2 = memberInfo is MethodBase;
                if (flag2) {
                    value.O = ValueTypeBox.Box(((MethodBase)memberInfo).MethodHandle, typeof(RuntimeMethodHandle));
                } else {
                    bool flag3 = memberInfo is FieldInfo;
                    if (flag3) {
                        value.O = ValueTypeBox.Box(((FieldInfo)memberInfo).FieldHandle, typeof(RuntimeFieldHandle));
                    }
                }
            }
            ctx.Stack.Push(value);
        }
    }
    internal static class ValueTypeBox {
        // Token: 0x06000181 RID: 385 RVA: 0x00009F14 File Offset: 0x00008114
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

        // Token: 0x06000182 RID: 386 RVA: 0x00009F64 File Offset: 0x00008164
        public static object Unbox(object box) {
            bool flag = box is IValueTypeBox;
            object result;
            if (flag) {
                result = ((IValueTypeBox)box).GetValue();
            } else {
                result = box;
            }
            return result;
        }
    }
}
