namespace Rhydon.Emulator.Handlers.VCall {
    class Unbox : KoiHandler {
        public Unbox(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_UNBOX;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
