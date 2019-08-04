namespace Rhydon.Emulator.Handlers.VCall {
    class Rangechk : KoiHandler {
        public Rangechk(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_RANGECHK;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
