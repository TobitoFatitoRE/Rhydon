namespace Rhydon.Emulator.Handlers {
    class SxByte : KoiHandler {
        public SxByte(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SX_BYTE;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SxDword : KoiHandler {
        public SxDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SX_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SxWord : KoiHandler {
        public SxWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SX_WORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
