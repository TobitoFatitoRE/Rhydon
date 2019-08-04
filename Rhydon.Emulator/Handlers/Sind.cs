using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class SindByte : KoiHandler {
        internal SindByte(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_BYTE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindDword : KoiHandler {
        internal SindDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindObject : KoiHandler {
        internal SindObject(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_OBJECT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindPtr : KoiHandler {
        internal SindPtr(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_PTR;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindQword : KoiHandler {
        internal SindQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindWord : KoiHandler {
        internal SindWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_WORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
