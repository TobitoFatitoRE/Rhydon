using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class LindByte : KoiHandler {
        public Constants Handles => Constants.OP_LIND_BYTE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindDword : KoiHandler {
        public Constants Handles => Constants.OP_LIND_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindObject : KoiHandler {
        public Constants Handles => Constants.OP_LIND_OBJECT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindPtr : KoiHandler {
        public Constants Handles => Constants.OP_LIND_PTR;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindQword : KoiHandler {
        public Constants Handles => Constants.OP_LIND_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindWord : KoiHandler {
        public Constants Handles => Constants.OP_LIND_WORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
