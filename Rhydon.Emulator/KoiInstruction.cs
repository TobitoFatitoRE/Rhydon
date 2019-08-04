using Rhydon.Core;

namespace Rhydon.Emulator {
    struct KoiInstruction {
        internal KoiInstruction(KoiOpCode code, object op = null) {
            OpCode = code;
            Operand = op;
        }

        internal KoiOpCode OpCode;
        internal object Operand;
    }
}
