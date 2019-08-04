namespace Rhydon.Emulator.Handlers.VCall {
    class Ckfinite : KoiHandler {
        public Ckfinite(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_CKFINITE;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class Ckoverflow : KoiHandler {
        public Ckoverflow(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_CKOVERFLOW;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
