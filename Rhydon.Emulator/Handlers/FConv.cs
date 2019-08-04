namespace Rhydon.Emulator.Handlers {
    class FConvR32 : KoiHandler {
        public FConvR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_FCONV_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class FConvR32R64 : KoiHandler {
        public FConvR32R64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_FCONV_R32_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class FConvR64 : KoiHandler {
        public FConvR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_FCONV_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class FConvR64R32 : KoiHandler {
        public FConvR64R32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_FCONV_R64_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
