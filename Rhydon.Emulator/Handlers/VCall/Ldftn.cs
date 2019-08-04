namespace Rhydon.Emulator.Handlers.VCall {
    class Ldftn : KoiHandler {
        public Ldftn(EmuContext ctx) : base(ctx) { }
        internal override byte Handles =>Ctx. Constants.VCALL_LDFTN;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
