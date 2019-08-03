using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class FConvR32 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_FCONV_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class FConvR32R64 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_FCONV_R32_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class FConvR64 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_FCONV_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class FConvR64R32 : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_FCONV_R64_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
