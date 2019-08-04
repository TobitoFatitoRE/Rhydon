using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ckfinite : KoiHandler {
        internal Ckfinite(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_CKFINITE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
    class Ckoverflow : KoiHandler {
        internal Ckoverflow(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_CKOVERFLOW;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
