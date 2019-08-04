using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ecall : KoiHandler {
        public Constants Handles => Constants.VCALL_ECALL;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
