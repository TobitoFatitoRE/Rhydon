namespace Rhydon.Emulator.Handlers {
    class DivDWord : KoiHandler {
        public DivDWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_DWORD;
        internal override void Emulate(EmuContext ctx) {
            VMSlot first = ctx.Stack.Pop();
            VMSlot second = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { U4 = first.U4 / second.U4 });
        }
    }

    class DivQWord : KoiHandler {
        public DivQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_QWORD;
        internal override void Emulate(EmuContext ctx) {
            VMSlot first = ctx.Stack.Pop();
            VMSlot second = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { U8 = first.U8 / second.U8 });
        }
    }

    class DivR32 : KoiHandler {
        public DivR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_R32;
        internal override void Emulate(EmuContext ctx) {
            VMSlot first = ctx.Stack.Pop();
            VMSlot second = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R4 = first.R4 / second.R4 });

        }
    }

    class DivR64 : KoiHandler {
        public DivR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_DIV_R64;
        internal override void Emulate(EmuContext ctx) {
            VMSlot first = ctx.Stack.Pop();
            VMSlot second = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R8 = first.R8 / second.R8 });

        }
    }
}
