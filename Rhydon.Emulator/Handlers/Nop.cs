using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Nop : KoiHandler {
        public Constants Handles => Constants.OP_NOP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
