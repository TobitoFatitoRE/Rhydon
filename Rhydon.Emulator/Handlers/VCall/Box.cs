using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Box : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_BOX;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
