using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Sizeof : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.VCALL_SIZEOF;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
