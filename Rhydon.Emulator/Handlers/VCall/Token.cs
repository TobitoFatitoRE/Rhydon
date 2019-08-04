using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Token : KoiHandler {
        internal Token(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_TOKEN;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
