using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Token : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_TOKEN;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
