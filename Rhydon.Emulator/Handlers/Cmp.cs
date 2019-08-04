using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Cmp : KoiHandler {
        public Constants Handles => Constants.OP_CMP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpDWord : KoiHandler {
        public Constants Handles => Constants.OP_CMP_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpQWord : KoiHandler {
        public Constants Handles => Constants.OP_CMP_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpR32 : KoiHandler {
        public Constants Handles => Constants.OP_CMP_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpR64 : KoiHandler {
        public Constants Handles => Constants.OP_CMP_R64;
        public void Emulate(EmuContext ctx) { 
            //throw new System.NotImplementedException();
        }
    }
}
