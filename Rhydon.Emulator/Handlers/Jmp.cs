using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Jmp : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_JMP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Jnz : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_JNZ;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Jz : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_JZ;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Swt : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SWT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
