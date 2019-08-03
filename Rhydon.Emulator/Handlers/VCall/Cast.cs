using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Cast : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_CAST;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
