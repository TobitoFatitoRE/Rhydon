namespace Rhydon.Emulator.Handlers.VCall {
    class Localloc : KoiHandler {
        public Localloc(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_LOCALLOC;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
