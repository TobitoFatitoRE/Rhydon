using Rhydon.Core;
using Rhydon.Core.Parser;

namespace Rhydon.Emulator {
    public class KoiEmulator {
        public KoiEmulator(RhydonContext ctx, MethodExport export) {
            Context = ctx;
            Export = export;
            Registers = new object[16];
            Ip = ctx.StartOffset - export.Offset;
        }

        public void EmulateNext() {
            var reader = Context.Reader;
            var code = reader.ReadKoiByte(Export);
            reader.ReadKoiByte(Export); //For "key fixup" according Koi source...

            Context.Logger.Debug($"{(KoiOpCodes)code}");
        }

        internal readonly RhydonContext Context;
        internal readonly MethodExport Export;
        internal object[] Registers;
        internal uint Ip;
    }
}
