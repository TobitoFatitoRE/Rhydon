using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ecall : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_ECALL;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
