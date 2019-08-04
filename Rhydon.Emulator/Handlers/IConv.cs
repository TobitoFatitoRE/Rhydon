namespace Rhydon.Emulator.Handlers {
    class IConvPtr : KoiHandler {
        public IConvPtr(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ICONV_PTR;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class IConvR64 : KoiHandler {
        public IConvR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ICONV_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
