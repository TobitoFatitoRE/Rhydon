namespace Rhydon.Emulator.Handlers.VCall {
    class Rangechk : VCallHandler {
        public Rangechk(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_RANGECHK;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
