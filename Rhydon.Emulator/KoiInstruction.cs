using Rhydon.Core;

namespace Rhydon.Emulator {
    struct KoiInstruction {
        internal KoiInstruction(KoiOpCodes code, object op = null) {
            OpCode = code;
            Operand = op;
        }

        internal KoiOpCodes OpCode;
        internal object Operand;
    }
}
