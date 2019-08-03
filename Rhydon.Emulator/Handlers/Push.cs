using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class PushRDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_PUSHR_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
