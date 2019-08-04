using System;
using System.Linq;
using Rhydon.Core;
using Rhydon.Core.Parser;

namespace Rhydon.Emulator {
    public class KoiEmulator {
        public KoiEmulator(RhydonContext ctx, MethodExport export) {
            _emuCtx = new EmuContext(ctx, export);

            ctx.Reader.BaseStream.Position = export.Offset;

            foreach (var h in typeof(KoiEmulator).Assembly.DefinedTypes
                .Where(t => !t.FullName.Contains(".VCall") && !t.IsAbstract && typeof(KoiHandler).IsAssignableFrom(t))
                .Select(ha => Activator.CreateInstance(ha, _emuCtx)).Cast<KoiHandler>().ToArray()) {
                _emuCtx.Handlers[h.Handles] = h;
            }

            ctx.Logger.Info($"Emulating virtualized method at offset: 0x{export.Offset:X8}");

            //_emuCtx.Registers[_emuCtx.Lookup(KoiOpCodes.REG_K1)] = new VMSlot { U4 = export.Key };
            //_emuCtx.Registers[_emuCtx.Lookup(KoiOpCodes.REG_BP)] = new VMSlot { U4 = 0 };
        }

        readonly EmuContext _emuCtx;

        public void EmulateNext() {
            var code = _emuCtx.ReadByte();
            _emuCtx.ReadByte(); //For "key fixup" according Koi source...

            var handler = _emuCtx.Handlers[code];
            _emuCtx.Logger.Info($"OpCode: {handler}");
            handler.Emulate(_emuCtx);
        }
    }
}
