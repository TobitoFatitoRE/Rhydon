using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class SindByte : KoiHandler {
        public Constants Handles => Constants.OP_SIND_BYTE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindDword : KoiHandler {
        public Constants Handles => Constants.OP_SIND_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindObject : KoiHandler {
        public Constants Handles => Constants.OP_SIND_OBJECT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindPtr : KoiHandler {
        public Constants Handles => Constants.OP_SIND_PTR;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindQword : KoiHandler { 
        public Constants Handles => Constants.OP_SIND_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SindWord : KoiHandler {
        public Constants Handles => Constants.OP_SIND_WORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
