using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class DivDWord : KoiHandler {
        internal DivDWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivQWord : KoiHandler {
        internal DivQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivR32 : KoiHandler {
        internal DivR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivR64 : KoiHandler {
        internal DivR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
