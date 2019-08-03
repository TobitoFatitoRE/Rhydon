using Rhydon.Core;
namespace Rhydon.Emulator.Handlers
{
    class Cmp : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_CMP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class CmpDWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_CMP_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class CmpQWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_CMP_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class CmpR32 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_CMP_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class CmpR64 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_CMP_R64;
        public void Emulate(EmuContext ctx) { 
            //throw new System.NotImplementedException();
        }
    }
}
