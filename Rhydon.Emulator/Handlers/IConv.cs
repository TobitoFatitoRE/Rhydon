using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class IConvPtr : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_ICONV_PTR;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class IConvR64 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_ICONV_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
