namespace Rhydon.Emulator.Handlers {
    class SubR32 : KoiHandler {
        public SubR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SUB_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R4 = (slot.R4 - slot2.R4) });
        }
    }

    class SubR64 : KoiHandler {
        public SubR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SUB_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R8 = (slot.R8 - slot2.R8) });
        }
    }
}
