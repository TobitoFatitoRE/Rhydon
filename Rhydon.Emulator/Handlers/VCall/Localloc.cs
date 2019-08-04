namespace Rhydon.Emulator.Handlers.VCall {
    class Localloc : VCallHandler {
        public Localloc(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_LOCALLOC;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
