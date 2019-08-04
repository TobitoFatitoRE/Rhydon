using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class ShlDword : KoiHandler {
        internal ShlDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SHL_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class ShlQword : KoiHandler {
        internal ShlQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SHL_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
