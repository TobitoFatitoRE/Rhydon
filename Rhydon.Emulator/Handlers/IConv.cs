using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class IConvPtr : KoiHandler {
        internal IConvPtr(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ICONV_PTR;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class IConvR64 : KoiHandler {
        internal IConvR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ICONV_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
