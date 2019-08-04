using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Nop : KoiHandler {
        internal Nop(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_NOP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
