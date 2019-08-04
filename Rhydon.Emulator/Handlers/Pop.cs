using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Pop : KoiHandler {
        public Constants Handles => Constants.OP_POP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }
}
