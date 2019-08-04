using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class RemDword : KoiHandler {
        internal RemDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class RemQword : KoiHandler {
        internal RemQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class RemR32 : KoiHandler {
        internal RemR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_R32;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class RemR64 : KoiHandler {
        internal RemR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_R64;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
