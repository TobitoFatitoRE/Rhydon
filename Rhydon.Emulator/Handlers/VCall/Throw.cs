using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Throw : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_THROW;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
