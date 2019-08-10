namespace Rhydon.Emulator.Handlers.VCall {
    class Rangechk : VCallHandler {
        public Rangechk(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_RANGECHK;
        internal override void EmulateVCall(EmuContext ctx) {
            VMSlot value = ctx.Stack.Pop();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            value.U8 = ((value.U8 > slot.U8 || value.U8 < slot2.U8) ? 1UL : 0UL);
            ctx.Stack.Push(value);
        }
    }
}
