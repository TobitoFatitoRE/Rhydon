using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Jmp : KoiHandler {
        public Constants Handles => Constants.OP_JMP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Jnz : KoiHandler {
        public Constants Handles => Constants.OP_JNZ;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Jz : KoiHandler {
        public Constants Handles => Constants.OP_JZ;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Swt : KoiHandler {
        public Constants Handles => Constants.OP_SWT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
