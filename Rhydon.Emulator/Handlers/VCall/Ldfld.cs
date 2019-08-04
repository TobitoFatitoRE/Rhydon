namespace Rhydon.Emulator.Handlers.VCall {
    class Ldfld : VCallHandler {
        public Ldfld(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_LDFLD;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
