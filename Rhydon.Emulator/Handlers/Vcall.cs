using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Vcall : KoiHandler {
        public Constants Handles => Constants.OP_VCALL;
        public void Emulate(EmuContext ctx) {
            var val = ctx.Stack.Pop().U1;
            var vcall = ctx.Lookup(val);

            vcall.Emulate(ctx);
        }
    }
}
