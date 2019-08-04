namespace Rhydon.Emulator.Handlers.VCall {
    class Cast : VCallHandler {
        public Cast(EmuContext ctx) : base(ctx) { }

        internal override byte VCall => Ctx.Constants.VCALL_CAST;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
