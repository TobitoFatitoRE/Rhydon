namespace Rhydon.Emulator.Handlers {
    class Leave : KoiHandler {
        public Leave(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LEAVE;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            //needs EHStack
        }
    }
}
