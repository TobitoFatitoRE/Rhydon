namespace Rhydon.Emulator.Handlers {
    class FConvR32 : KoiHandler {
        public FConvR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_FCONV_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            slot.R4 = (float)slot.U8;
            ctx.Stack.Push(slot);
        }
    }

    class FConvR32R64 : KoiHandler {
        public FConvR32R64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_FCONV_R32_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            slot.R8 = (double)slot.R4;
            ctx.Stack.Push(slot);
        }
    }

    class FConvR64 : KoiHandler {
        public FConvR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_FCONV_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            slot.R8 = (double)slot.U8;
            ctx.Stack.Push(slot);
        }
    }

    class FConvR64R32 : KoiHandler {
        public FConvR64R32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_FCONV_R64_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            slot.R4 = (float)slot.R8;
            ctx.Stack.Push(slot);
        }
    }
}
