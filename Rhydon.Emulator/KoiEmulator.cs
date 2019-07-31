using Rhydon.Core;
using Rhydon.Core.HeapParser;

namespace Rhydon.Emulator {
    public class KoiEmulator {
        public KoiEmulator(RhydonContext ctx, MethodEntry export) {
            Context = ctx;
            Export = export;
            Registers = new object[16];
            Ip = export.Offset;
        }

        public void ExecuteNext() {
            var reader = Context.HeapReader;
            var code = reader.ReadKoiByte(Export);
            reader.ReadKoiByte(Export); //For "key fixup" according Koi source...

            Context.Logger.Debug($"{(KoiOpCodes)code}");
        }

        internal readonly RhydonContext Context;
        internal readonly MethodEntry Export;
        internal object[] Registers;
        internal uint Ip;
    }
}
