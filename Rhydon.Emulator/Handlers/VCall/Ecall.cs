namespace Rhydon.Emulator.Handlers.VCall {
    class Ecall : VCallHandler {
        public Ecall(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_ECALL;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
