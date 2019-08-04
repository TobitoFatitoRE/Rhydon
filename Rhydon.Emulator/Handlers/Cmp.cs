using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Cmp : KoiHandler {
        internal Cmp(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpDWord : KoiHandler {
        internal CmpDWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpQWord : KoiHandler {
        internal CmpQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpR32 : KoiHandler {
        internal CmpR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpR64 : KoiHandler {
        internal CmpR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP_R64;
        public void Emulate(EmuContext ctx) { 
            //throw new System.NotImplementedException();
        }
    }
}
