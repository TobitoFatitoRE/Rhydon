using Rhydon.Core;

namespace Rhydon.Emulator.Handlers
{
    class Call : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_CALL;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
