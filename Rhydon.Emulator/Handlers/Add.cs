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
        public Constants Handles => Constants.OP_ADD_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddR32 : KoiHandler {
        public Constants Handles => Constants.OP_ADD_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddR64 : KoiHandler {
        public Constants Handles => Constants.OP_ADD_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
