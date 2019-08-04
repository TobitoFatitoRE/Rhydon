namespace Rhydon.Emulator.Handlers.VCall {
    class Unbox : VCallHandler {
        public Unbox(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_UNBOX;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
