using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Ldftn : KoiHandler {
        internal Ldftn(EmuContext ctx) : base(ctx) { }
        internal override byte Handles =>Ctx. Constants.VCALL_LDFTN;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
