using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Vcall : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_VCALL;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
