using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class NorDword : KoiHandler {
        internal NorDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_NOR_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class NorQword : KoiHandler {
        internal NorQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_NOR_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
