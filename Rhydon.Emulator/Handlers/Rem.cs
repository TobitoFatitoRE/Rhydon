using Rhydon.Core;
namespace Rhydon.Emulator.Handlers
{
    class RemDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_REM_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class RemQword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_REM_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class RemR32 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_REM_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class RemR64 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_REM_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
