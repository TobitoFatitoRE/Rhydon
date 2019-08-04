namespace Rhydon.Emulator.Handlers.VCall {
    class Token : VCallHandler {
        public Token(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_TOKEN;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
