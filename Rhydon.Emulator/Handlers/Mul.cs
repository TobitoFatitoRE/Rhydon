namespace Rhydon.Emulator.Handlers {
    class MulDword : KoiHandler {
        public MulDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulQWord : KoiHandler {
        public MulQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulR32 : KoiHandler {
        public MulR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class MulR64 : KoiHandler {
        public MulR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
