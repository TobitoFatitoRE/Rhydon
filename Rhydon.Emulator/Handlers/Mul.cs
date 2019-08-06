namespace Rhydon.Emulator.Handlers {
    class MulDword : KoiHandler {
        public MulDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            VMSlot slotnew = new VMSlot();
            ulong num2 = (ulong)(slot.U4 * slot2.U4);
            slotnew.U4 = (uint)num2;
            ctx.Stack.Push(slotnew);
        }
    }

    class MulQWord : KoiHandler {
        public MulQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { U8 = slot.U4 * slot2.U4 });
        }
    }

    class MulR32 : KoiHandler {
        public MulR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R4 = slot.R4 * slot2.R4 });
        }
    }

    class MulR64 : KoiHandler {
        public MulR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_MUL_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R8 = slot.R8 * slot2.R8 });
        }
    }
}
