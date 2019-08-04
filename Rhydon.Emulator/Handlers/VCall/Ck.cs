using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ckfinite : KoiHandler {
        public Constants Handles => Constants.VCALL_CKFINITE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class Ckoverflow : KoiHandler {
        public Constants Handles => Constants.VCALL_CKOVERFLOW;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
