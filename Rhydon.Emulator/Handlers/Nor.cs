using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class NorDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_NOR_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class NorQword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_NOR_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
