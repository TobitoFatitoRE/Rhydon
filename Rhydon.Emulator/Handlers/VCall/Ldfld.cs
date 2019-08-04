using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ldfld : KoiHandler {
        internal Ldfld(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_LDFLD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
