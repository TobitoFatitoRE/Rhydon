using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Sizeof : KoiHandler {
        internal Sizeof(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_SIZEOF;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
