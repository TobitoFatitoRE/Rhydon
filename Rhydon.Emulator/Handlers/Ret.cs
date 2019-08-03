using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Ret : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_RET;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
