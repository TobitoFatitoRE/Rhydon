using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Ret : KoiHandler {
        internal Ret(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_RET;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
