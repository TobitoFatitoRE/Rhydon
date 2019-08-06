namespace Rhydon.Emulator.Handlers {
    class NorDword : KoiHandler {
        public NorDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_NOR_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { U4 = ~(slot.U4 | slot2.U4) });
        }
    }

    class NorQword : KoiHandler {
        public NorQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_NOR_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { U8 = ~(slot.U8 | slot2.U8) });
        }
    }
}
