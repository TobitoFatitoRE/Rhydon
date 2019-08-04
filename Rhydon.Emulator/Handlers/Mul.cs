using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class MulDword : KoiHandler {
        public Constants Handles => Constants.OP_MUL_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulQWord : KoiHandler {
        public Constants Handles => Constants.OP_MUL_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulR32 : KoiHandler {
        public Constants Handles => Constants.OP_MUL_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulR64 : KoiHandler {
        public Constants Handles => Constants.OP_MUL_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
