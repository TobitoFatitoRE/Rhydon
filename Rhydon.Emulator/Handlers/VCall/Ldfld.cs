using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ldfld : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_LDFLD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
