using Rhydon.Core;

namespace Rhydon.Emulator {
    interface IKoiHandler {
        KoiOpCodes Handles { get; }
        void Emulate(EmuContext ctx);
    }
}
