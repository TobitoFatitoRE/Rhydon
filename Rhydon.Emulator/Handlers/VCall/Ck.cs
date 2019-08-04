namespace Rhydon.Emulator.Handlers.VCall {
    class Ckfinite : VCallHandler {
        public Ckfinite(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_CKFINITE;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class Ckoverflow : VCallHandler {
        public Ckoverflow(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_CKOVERFLOW;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
