using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class ShrDword : KoiHandler {
        public Constants Handles => Constants.OP_SHR_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class ShrQword : KoiHandler {
        public Constants Handles => Constants.OP_SHR_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
