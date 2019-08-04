using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Throw : KoiHandler {
        internal Throw(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_THROW;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
