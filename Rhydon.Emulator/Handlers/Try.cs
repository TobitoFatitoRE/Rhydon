using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Try : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_TRY;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
