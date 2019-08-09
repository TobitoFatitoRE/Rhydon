namespace Rhydon.Emulator.Handlers.VCall {
    class Ckfinite : VCallHandler {
        public Ckfinite(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_CKFINITE;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot slot = ctx.Stack.Pop();
            byte u2 = ctx.Registers[(int)ctx.Constants.REG_FL].U1;
            bool flag = (u2 & ctx.Constants.FL_UNSIGNED) > 0;
            if(flag) {
                float r = slot.R4;
                bool flag2 = float.IsNaN(r) || float.IsInfinity(r);
                if(flag2) {
                    //throw arithmeticexception
                } 
            } else {
                double r2 = slot.R8;
                bool flag3 = double.IsNaN(r2) || double.IsInfinity(r2);
                if (flag3) {
                    //throw arithmeticexception
                }
            }
        }
    }
    class Ckoverflow : VCallHandler {
        public Ckoverflow(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_CKOVERFLOW;
        internal override void EmulateVCall(EmuContext ctx) {
           if(ctx.Stack.Pop().U4 >0u) {
                //throw overflow
            }
        }
    }
}
