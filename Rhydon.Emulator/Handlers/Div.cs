using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class DivDWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_DIV_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivQWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_DIV_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivR32 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_DIV_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivR64 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_DIV_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
