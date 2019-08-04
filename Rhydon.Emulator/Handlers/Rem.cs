using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class RemDword : KoiHandler {
        public Constants Handles => Constants.OP_REM_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class RemQword : KoiHandler {
        public Constants Handles => Constants.OP_REM_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class RemR32 : KoiHandler {
        public Constants Handles => Constants.OP_REM_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class RemR64 : KoiHandler {
        public Constants Handles => Constants.OP_REM_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
