using System.Reflection;

namespace Rhydon.Emulator.Handlers.VCall {
    class Ecall : VCallHandler {
        public Ecall(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_ECALL;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            uint id = slot.U4 & 1073741823u;
            byte b = (byte)(slot.U4 >> 30);
            var method = ctx.Header.References[id];
            ctx.Logger.Info("Emulating VCall OpCode - Found Method: " + method.FullName); // tostring gives more info than .name :P
            bool flag = b == ctx.Constants.ECALL_CALLVIRT_CONSTRAINED;
            if(!flag) {
                flag = NeedTypedInvoke((MethodBase)method, b == ctx.Constants.ECALL_NEWOBJ);
            }
            if(flag) {
                //Invoke Typed
            } else {
                //Invoke Normal
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
    }
}
