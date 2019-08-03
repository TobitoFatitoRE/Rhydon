using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Exit : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_EXIT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
