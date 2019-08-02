using Rhydon.Core;
using Rhydon.Core.Parser;

namespace Rhydon.Emulator {
    public class KoiEmulator {
        public KoiEmulator(RhydonContext ctx, MethodExport export) {
            _ctx = ctx;
            _exp = export;

            _ctx.Reader.BaseStream.Position = export.Offset;
        }

        readonly RhydonContext _ctx;
        readonly MethodExport _exp;

        public void EmulateNext() {
            var reader = _ctx.Reader;
            var code = reader.ReadKoiByte(_exp);

            reader.ReadKoiByte(_exp); //For "key fixup" according Koi source...

            _ctx.Logger.Debug($"{_ctx.Map[code]}");
        }
    }
}
