namespace Rhydon.Emulator.Handlers.VCall {
    class Stfld : KoiHandler {
        public Stfld(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_STFLD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
