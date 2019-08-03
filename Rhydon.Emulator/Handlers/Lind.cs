using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class LindByte : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_LIND_BYTE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_LIND_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindObject : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_LIND_OBJECT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindPtr : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_LIND_PTR;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindQword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_LIND_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class LindWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_LIND_WORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
