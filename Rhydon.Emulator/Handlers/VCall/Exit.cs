namespace Rhydon.Emulator.Handlers.VCall {
    class Exit : VCallHandler {
        public Exit(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_EXIT;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
