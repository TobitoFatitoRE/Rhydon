using Rhydon.Core;
namespace Rhydon.Emulator.Handlers
{
    class SindByte : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SIND_BYTE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class SindDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SIND_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class SindObject : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SIND_OBJECT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class SindPtr : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SIND_PTR;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class SindQword : IKoiHandler { 
        public KoiOpCodes Handles => KoiOpCodes.OP_SIND_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class SindWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SIND_WORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
