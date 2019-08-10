namespace Rhydon.Emulator.Handlers.VCall {
    class Throw : VCallHandler {
        public Throw(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_THROW;
        internal override void EmulateVCall(EmuContext ctx) {
            uint u2 = ctx.Stack.Pop().U4;
        }
    }
}
