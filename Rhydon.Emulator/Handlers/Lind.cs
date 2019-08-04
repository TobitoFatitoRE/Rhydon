using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class LindByte : KoiHandler {
        internal LindByte(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_BYTE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindDword : KoiHandler {
        internal LindDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindObject : KoiHandler {
        internal LindObject(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_OBJECT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindPtr : KoiHandler {
        internal LindPtr(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_PTR;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindQword : KoiHandler {
        internal LindQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindWord : KoiHandler {
        internal LindWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_WORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
