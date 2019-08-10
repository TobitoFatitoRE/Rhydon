using System;
using System.Reflection;

namespace Rhydon.Emulator.Handlers.VCall {
    class Ecall : VCallHandler {
        public Ecall(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_ECALL;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot slot = ctx.Stack.Pop();
            uint id = slot.U4 & 1073741823u;
            byte b = (byte)(slot.U4 >> 30);
            var method = ctx.Header.References[id];
            ctx.Logger.Info("Emulating VCall OpCode - Found Method: " + method.FullName); 
            bool flag = b == ctx.Constants.ECALL_CALLVIRT_CONSTRAINED;
            if(!flag) {
                flag = NeedTypedInvoke((MethodBase)method, b == ctx.Constants.ECALL_NEWOBJ);
            }
            if(flag) {
                //Invoke Typed
            } else {
                InvokeNormal(ctx, (MethodBase)method, b);
            }
        }
        private void InvokeNormal(EmuContext ctx, MethodBase targetMethod, byte opCode) {
            ParameterInfo[] parameters = targetMethod.GetParameters();
            object[] array = new object[parameters.Length];
            bool flag = opCode == ctx.Constants.ECALL_CALL && targetMethod.IsVirtual;
            object obj = null;
            if(flag) {
                int num2 = targetMethod.IsStatic ? 0 : 1;
                array = new object[parameters.Length + num2];
                for (int i = parameters.Length - 1; i >= 0; i--) {
                    array[i + num2] = Ecall.PopObject(ctx, parameters[i].ParameterType);
                }
                bool flag2 = !targetMethod.IsStatic;
                if (flag2) {
                    array[0] = Ecall.PopObject(ctx, targetMethod.DeclaringType);
                }
               // targetMethod = DirectCall.GetDirectInvocationProxy(targetMethod); Needs the dynamic method shit smh
            } else {
                array = new object[parameters.Length];
                for (int j = parameters.Length - 1; j >= 0; j--) {
                    array[j] = Ecall.PopObject(ctx, parameters[j].ParameterType);
                }
                bool flag3 = !targetMethod.IsStatic && opCode != ctx.Constants.ECALL_NEWOBJ;
                if (flag3) {
                    obj = Ecall.PopObject(ctx, targetMethod.DeclaringType);
                    bool flag4 = obj != null && !targetMethod.DeclaringType.IsInstanceOfType(obj);
                    if (flag4) {
                        //InvokeTyped(ctx, targetMethod, opCode);
                        return;
                    }
                }
            }

        }
            private static bool NeedTypedInvoke( MethodBase method, bool isNewObj) {
            bool flag = !isNewObj && !method.IsStatic;
            if (flag) {
                bool isValueType = method.DeclaringType.IsValueType;
                if (isValueType) {
                    return true;
                }
            }
            foreach (ParameterInfo parameterInfo in method.GetParameters()) {
                bool isByRef = parameterInfo.ParameterType.IsByRef;
                if (isByRef) {
                    return true;
                }
            }
            return method is MethodInfo && ((MethodInfo)method).ReturnType.IsByRef;
        }
        private static object PopObject(EmuContext ctx, Type type) {

            VMSlot vmslot = ctx.Stack.Pop();
            bool flag = Type.GetTypeCode(type) == TypeCode.String && vmslot.O == null;
            object result;
            if (flag) {
                result = ctx.Header.References[vmslot.U4];
            } else {
                result = vmslot.ToObject(type);
            }
            return result;
        }
    }
}
