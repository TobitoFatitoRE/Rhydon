using Rhydon.Core;
namespace Rhydon.Emulator.Handlers
{
    class SubR32 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SUB_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class SubR64 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_SUB_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
