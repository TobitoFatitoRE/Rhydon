using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ldftn : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_LDFTN;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
