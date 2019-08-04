namespace Rhydon.Emulator.Handlers {
    class RemDword : KoiHandler {
        public RemDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class RemQword : KoiHandler {
        public RemQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class RemR32 : KoiHandler {
        public RemR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class RemR64 : KoiHandler {
        public RemR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
