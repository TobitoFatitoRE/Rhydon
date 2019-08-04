using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Throw : KoiHandler {
        public Constants Handles => Constants.VCALL_THROW;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
