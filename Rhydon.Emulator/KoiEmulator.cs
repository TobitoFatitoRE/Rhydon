using System;
using System.Linq;
using Rhydon.Core;
using Rhydon.Core.Parser;

namespace Rhydon.Emulator {
    public class KoiEmulator {
        public KoiEmulator(RhydonContext ctx, MethodExport export) {
            _ctx = ctx;
            _exp = export;
            _emuCtx = new EmuContext(_ctx, _exp);

            _ctx.Reader.BaseStream.Position = export.Offset;

            foreach (var h in typeof(KoiEmulator).Assembly.DefinedTypes
                .Where(t => !t.IsInterface && typeof(IKoiHandler).IsAssignableFrom(t))
                .Select(Activator.CreateInstance).Cast<IKoiHandler>().ToArray()) {
                _emuCtx.Handlers[h.Handles] = h;
            }

            ctx.Logger.Info($"Emulating virtualized method at offset: 0x{export.Offset:X8}");

            _emuCtx.Registers[_emuCtx.Lookup(KoiOpCodes.REG_K1)] = new VMSlot { U4 = export.Key };
            _emuCtx.Registers[_emuCtx.Lookup(KoiOpCodes.REG_BP)] = new VMSlot { U4 = 0 };
        }

        readonly RhydonContext _ctx;
        readonly EmuContext _emuCtx;
        readonly MethodExport _exp;

        public void EmulateNext() {
            var reader = _ctx.Reader;
            var code = _ctx.Map[reader.ReadKoiByte(_exp)];

            reader.ReadKoiByte(_exp); //For "key fixup" according Koi source...

            _ctx.Logger.Debug(code.ToString());
            _emuCtx.Handlers[code].Emulate(_emuCtx);
        }
    }
}
