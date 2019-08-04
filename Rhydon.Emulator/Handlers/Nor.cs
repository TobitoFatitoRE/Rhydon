using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class NorDword : KoiHandler {
        public Constants Handles => Constants.OP_NOR_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class NorQword : KoiHandler {
        public Constants Handles => Constants.OP_NOR_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
