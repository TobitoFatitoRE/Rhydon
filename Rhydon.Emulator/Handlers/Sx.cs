using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class SxByte : KoiHandler {
        internal SxByte(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SX_BYTE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SxDword : KoiHandler {
        internal SxDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SX_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SxWord : KoiHandler {
        internal SxWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SX_WORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
