namespace Rhydon.Emulator.Handlers.VCall {
    class Initobj : VCallHandler {
        public Initobj(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_INITOBJ;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
