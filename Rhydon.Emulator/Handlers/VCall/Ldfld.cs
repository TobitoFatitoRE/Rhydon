namespace Rhydon.Emulator.Handlers.VCall {
    class Ldfld : KoiHandler {
        public Ldfld(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_LDFLD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
