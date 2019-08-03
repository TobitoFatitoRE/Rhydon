using Rhydon.Core;
namespace Rhydon.Emulator.Handlers
{
    class SxByte : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SX_BYTE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class SxDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SX_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class SxWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SX_WORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
