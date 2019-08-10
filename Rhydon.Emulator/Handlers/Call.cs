namespace Rhydon.Emulator.Handlers {
    class Call : KoiHandler {
        public Call(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_CALL;
        internal override void Emulate(EmuContext ctx) {
            ctx.Reader.BaseStream.Position = (long)ctx.Stack.Pop().U8;
        }
    }
}
