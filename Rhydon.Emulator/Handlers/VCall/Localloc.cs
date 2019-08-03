using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Localloc : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_LOCALLOC;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
