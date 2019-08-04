namespace Rhydon.Emulator.Handlers {
    class DivDWord : KoiHandler {
        public DivDWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivQWord : KoiHandler {
        public DivQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivR32 : KoiHandler {
        public DivR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class DivR64 : KoiHandler {
        public DivR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
