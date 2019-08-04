namespace Rhydon.Emulator.Handlers.VCall {
    class Ecall : KoiHandler {
        public Ecall(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_ECALL;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
