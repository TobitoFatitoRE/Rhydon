using Rhydon.Core;
namespace Rhydon.Emulator.Handlers
{
    class ShlDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SHL_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class ShlQword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SHL_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
