using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class MulDword : KoiHandler {
        internal MulDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulQWord : KoiHandler {
        internal MulQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulR32 : KoiHandler {
        internal MulR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulR64 : KoiHandler {
        internal MulR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
