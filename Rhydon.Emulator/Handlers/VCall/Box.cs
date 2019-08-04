using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Box : KoiHandler {
        internal Box(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_BOX;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
