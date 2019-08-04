namespace Rhydon.Emulator.Handlers.VCall {
    class Box : VCallHandler {
        public Box(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_BOX;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
