using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ecall : KoiHandler {
        internal Ecall(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_ECALL;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
