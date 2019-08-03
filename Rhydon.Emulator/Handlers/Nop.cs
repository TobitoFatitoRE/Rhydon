using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Nop : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_NOP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
