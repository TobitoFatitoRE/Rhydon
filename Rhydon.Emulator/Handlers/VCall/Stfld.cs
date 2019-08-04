namespace Rhydon.Emulator.Handlers.VCall {
    class Stfld : VCallHandler {
        public Stfld(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_STFLD;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
