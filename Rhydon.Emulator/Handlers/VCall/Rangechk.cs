using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Rangechk : KoiHandler {
        internal Rangechk(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_RANGECHK;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
