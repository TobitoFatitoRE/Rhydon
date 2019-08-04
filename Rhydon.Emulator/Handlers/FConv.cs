using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class FConvR32 : KoiHandler {
        public Constants Handles => Constants.OP_FCONV_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class FConvR32R64 : KoiHandler {
        public Constants Handles => Constants.OP_FCONV_R32_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class FConvR64 : KoiHandler {
        public Constants Handles => Constants.OP_FCONV_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class FConvR64R32 : KoiHandler {
        public Constants Handles => Constants.OP_FCONV_R64_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
