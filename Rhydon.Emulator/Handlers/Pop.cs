using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Pop : KoiHandler {
        public Pop(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_POP;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }
}
