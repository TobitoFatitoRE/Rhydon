using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Call : KoiHandler {
        internal Call(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CALL;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
