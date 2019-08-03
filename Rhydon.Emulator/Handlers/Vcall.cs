using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Vcall : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_VCALL;
        public void Emulate(EmuContext ctx) {
            var val = ctx.Stack.Pop().U1;
            var vcall = ctx.Lookup(val);

            vcall.Emulate(ctx);
        }
    }
}
