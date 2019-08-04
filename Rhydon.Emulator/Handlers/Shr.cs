using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class ShrDword : KoiHandler {
        internal ShrDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SHR_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class ShrQword : KoiHandler {
        internal ShrQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SHR_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
