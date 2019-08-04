namespace Rhydon.Emulator.Handlers.VCall {
    class Initobj : KoiHandler {
        public Initobj(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_INITOBJ;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
