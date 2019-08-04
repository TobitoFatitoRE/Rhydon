namespace Rhydon.Emulator.Handlers.VCall {
    class Throw : KoiHandler {
        public Throw(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_THROW;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
