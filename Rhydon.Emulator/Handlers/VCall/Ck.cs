using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ckfinite : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_CKFINITE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class Ckoverflow : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_CKOVERFLOW;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
