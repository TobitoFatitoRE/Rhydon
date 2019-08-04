using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class ShlDword : KoiHandler {
        public Constants Handles => Constants.OP_SHL_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class ShlQword : KoiHandler {
        public Constants Handles => Constants.OP_SHL_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
