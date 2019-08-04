using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class DivDWord : KoiHandler {
        public Constants Handles => Constants.OP_DIV_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivQWord : KoiHandler {
        public Constants Handles => Constants.OP_DIV_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivR32 : KoiHandler {
        public Constants Handles => Constants.OP_DIV_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivR64 : KoiHandler {
        public Constants Handles => Constants.OP_DIV_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
