namespace Rhydon.Emulator.Handlers {
    class AddDWord : KoiHandler {
        public AddDWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddQWord : KoiHandler {
        public AddQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddR32 : KoiHandler {
        public AddR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class AddR64 : KoiHandler {
        public AddR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
