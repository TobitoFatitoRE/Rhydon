namespace Rhydon.Emulator.Handlers {
    class SubR32 : KoiHandler {
        public SubR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SUB_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SubR64 : KoiHandler {
        public SubR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SUB_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
