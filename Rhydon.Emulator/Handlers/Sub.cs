using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class SubR32 : KoiHandler {
        public Constants Handles => Constants.OP_SUB_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SubR64 : KoiHandler {
        public Constants Handles => Constants.OP_SUB_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
