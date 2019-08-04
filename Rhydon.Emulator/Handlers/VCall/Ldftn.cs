namespace Rhydon.Emulator.Handlers.VCall {
    class Ldftn : VCallHandler {
        public Ldftn(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx. Constants.VCALL_LDFTN;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
