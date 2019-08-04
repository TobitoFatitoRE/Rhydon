using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Cast : KoiHandler {
        internal Cast(EmuContext ctx) : base(ctx) { }

        internal override byte Handles => Ctx.Constants.VCALL_CAST;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
