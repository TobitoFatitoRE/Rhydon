namespace Rhydon.Emulator.Handlers {
    class Nop : KoiHandler {
        public Nop(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_NOP;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
