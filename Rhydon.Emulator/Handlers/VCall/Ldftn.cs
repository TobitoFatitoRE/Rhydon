using System;
using System.Collections.Generic;
using System.Reflection;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ldftn : VCallHandler {
        public Ldftn(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx. Constants.VCALL_LDFTN;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            if(slot2.O != null) {
                MethodInfo methodInfo = (MethodInfo)ctx.Header.References[slot.U4];
                Type type = slot2.O.GetType();
                List<Type> list = new List<Type>();
                do {
                    list.Add(type);
                    type = type.BaseType;
                }
                while (type != null && type != methodInfo.DeclaringType);
                list.Reverse();
                MethodInfo methodInfo2 = methodInfo;
                foreach (Type type2 in list) {
                    foreach (MethodInfo methodInfo3 in type2.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)) {
                        bool flag2 = methodInfo3.GetBaseDefinition() == methodInfo2;
                        if (flag2) {
                            methodInfo2 = methodInfo3;
                            break;
                        }
                    }
                }
                ctx.Stack.Push(new VMSlot() { U8 = (ulong)((long)methodInfo2.MethodHandle.GetFunctionPointer()) });
            } 
            if(slot2.U8 > 0UL) {
                uint u = ctx.Stack.Pop().U4;
                ulong u2 = slot.U8;
               // VMFuncSig TODO: VMFuncSig,VMTrampoline

            } else {
                MethodBase methodBase = (MethodBase)ctx.Header.References[slot.U4];
                ctx.Stack.Push(new VMSlot() { U8 = (ulong)((long)methodBase.MethodHandle.GetFunctionPointer()) });
            }
        }
    }
}
