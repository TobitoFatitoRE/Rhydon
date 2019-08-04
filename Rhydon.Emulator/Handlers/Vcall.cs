namespace Rhydon.Emulator.Handlers {
    class Vcall : KoiHandler {
        public Vcall(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_VCALL;
        internal override void Emulate(EmuContext ctx) {
            var val = ctx.Stack.Pop().U1;
            var vcall = ctx.Lookup(val);

            vcall.Emulate(ctx);
        }
    }
}
