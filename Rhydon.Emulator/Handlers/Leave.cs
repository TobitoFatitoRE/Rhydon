using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Leave : KoiHandler {
        internal Leave(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LEAVE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
