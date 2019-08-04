using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class IConvPtr : KoiHandler {
        public Constants Handles => Constants.OP_ICONV_PTR;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class IConvR64 : KoiHandler {
        public Constants Handles => Constants.OP_ICONV_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
