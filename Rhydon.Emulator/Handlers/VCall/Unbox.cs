using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Unbox : KoiHandler {
        internal Unbox(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_UNBOX;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
