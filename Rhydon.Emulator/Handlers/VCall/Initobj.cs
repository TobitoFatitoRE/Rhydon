using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Initobj : KoiHandler {
        internal Initobj(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_INITOBJ;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
