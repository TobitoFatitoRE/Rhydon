using System.Reflection;

namespace Rhydon.Emulator.Handlers.VCall {
    class Ecall : VCallHandler {
        public Ecall(EmuContext ctx) : base(ctx) { }
        internal override byte VCall => Ctx.Constants.VCALL_ECALL;
        internal override void EmulateVCall(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            uint id = slot.U4 & 1073741823u;
            byte b = (byte)(slot.U4 >> 30);
            var method = ctx.Header.References[id].FullName;
            ctx.Logger.Info("Emulating VCall OpCode - Found Method: " + method); // tostring gives more info than .name :P
        }
    }
}
