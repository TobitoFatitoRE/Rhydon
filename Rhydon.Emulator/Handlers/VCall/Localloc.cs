namespace Rhydon.Emulator.Handlers.VCall {
    class Localloc : VCallHandler {
        public Localloc(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_LOCALLOC;
        internal override void EmulateVCall(EmuContext ctx) {
            uint u3 = ctx.Stack.Pop().U4;
            //ctx.Stack.Push(new VMSlot() { U8 = (ulong)((long)ctx.Stack.Localloc(u2,u3))}) todo: localloc
        }
    }
}
