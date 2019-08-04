using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Exit : KoiHandler {
        internal Exit(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_EXIT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
