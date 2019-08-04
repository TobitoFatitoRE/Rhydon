using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Stfld : KoiHandler {
        internal Stfld(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_STFLD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
