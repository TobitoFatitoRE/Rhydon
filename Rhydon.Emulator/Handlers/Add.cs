using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class AddDWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_ADD_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddQWord : IKoiHandler
    {
        public KoiOpCodes Handles => KoiOpCodes.OP_ADD_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddR32 : IKoiHandler
    {
        public KoiOpCodes Handles => KoiOpCodes.OP_ADD_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddR64 : IKoiHandler
    {
        public KoiOpCodes Handles => KoiOpCodes.OP_ADD_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
