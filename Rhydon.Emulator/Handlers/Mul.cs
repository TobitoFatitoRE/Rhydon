using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class MulDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_MUL_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulQWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_MUL_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulR32 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_MUL_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulR64 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_MUL_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
