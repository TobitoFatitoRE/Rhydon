using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Try : KoiHandler {
        internal Try(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_TRY;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
