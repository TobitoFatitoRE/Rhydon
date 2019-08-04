using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class SubR32 : KoiHandler {
        internal SubR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SUB_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class SubR64 : KoiHandler {
        internal SubR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SUB_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
