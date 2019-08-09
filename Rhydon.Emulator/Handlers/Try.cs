namespace Rhydon.Emulator.Handlers {
    class Try : KoiHandler {
        public Try(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_TRY;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            // TODO: EHFrame,EHStack
        }
    }
}
