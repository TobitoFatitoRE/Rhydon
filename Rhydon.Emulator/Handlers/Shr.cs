using Rhydon.Core;
namespace Rhydon.Emulator.Handlers
{
    class ShrDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SHR_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class ShrQword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SHR_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
