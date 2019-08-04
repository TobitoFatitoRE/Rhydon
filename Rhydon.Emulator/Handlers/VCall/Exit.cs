namespace Rhydon.Emulator.Handlers.VCall {
    class Exit : KoiHandler {
        public Exit(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_EXIT;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
