using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class AddDWord : KoiHandler {
        internal AddDWord(EmuContext ctx) : base(ctx) { }

        internal override byte Handles => Ctx.Constants.OP_ADD_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddQWord : KoiHandler {
        internal AddQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddR32 : KoiHandler {
        internal AddR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddR64 : KoiHandler {
        internal AddR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
