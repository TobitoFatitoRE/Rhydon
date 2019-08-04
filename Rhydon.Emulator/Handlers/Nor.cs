namespace Rhydon.Emulator.Handlers {
    class NorDword : KoiHandler {
        public NorDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_NOR_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class NorQword : KoiHandler {
        public NorQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_NOR_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
