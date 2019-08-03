using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Unbox : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_UNBOX;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
