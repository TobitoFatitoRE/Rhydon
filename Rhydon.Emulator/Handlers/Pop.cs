namespace Rhydon.Emulator.Handlers {
    class Pop : KoiHandler {
        public Pop(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_POP;
        internal override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            var regid = ctx.ReadByte();

            if (regid == ctx.Constants.REG_SP || regid == ctx.Constants.REG_BP && slot.O is null)
                ctx.Registers[regid] = VMSlot.Null;
            else ctx.Registers[regid] = slot;
        }
    }
}
