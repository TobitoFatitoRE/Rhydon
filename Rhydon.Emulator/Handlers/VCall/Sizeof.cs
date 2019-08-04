namespace Rhydon.Emulator.Handlers.VCall {
    class Sizeof : KoiHandler {
        public Sizeof(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_SIZEOF;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
