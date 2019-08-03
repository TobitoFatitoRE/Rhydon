using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Pop : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_POP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }
}
