using Rhydon.Core;
namespace Rhydon.Emulator.Handlers
{
    class Leave : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_LEAVE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
