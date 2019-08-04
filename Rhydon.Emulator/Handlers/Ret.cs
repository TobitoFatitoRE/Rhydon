namespace Rhydon.Emulator.Handlers {
    class Ret : KoiHandler {
        public Ret(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_RET;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
