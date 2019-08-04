namespace Rhydon.Emulator.Handlers.VCall {
    class Sizeof : VCallHandler {
        public Sizeof(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_SIZEOF;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
