using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Initobj : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_INITOBJ;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
