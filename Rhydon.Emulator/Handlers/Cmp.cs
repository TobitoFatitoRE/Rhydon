namespace Rhydon.Emulator.Handlers {
    class Cmp : KoiHandler {
        public Cmp(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpDWord : KoiHandler {
        public CmpDWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpQWord : KoiHandler {
        public CmpQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpR32 : KoiHandler {
        public CmpR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class CmpR64 : KoiHandler {
        public CmpR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CMP_R64;
        internal override void Emulate(EmuContext ctx) { 
            //throw new System.NotImplementedException();
        }
    }
}
