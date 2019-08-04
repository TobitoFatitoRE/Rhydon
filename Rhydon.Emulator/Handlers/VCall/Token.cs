namespace Rhydon.Emulator.Handlers.VCall {
    class Token : KoiHandler {
        public Token(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_TOKEN;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
