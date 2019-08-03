using System;
using System.Collections.Generic;
using System.Linq;
using Rhydon.Core;
using Rhydon.Core.Parser;

namespace Rhydon.Emulator {
    public class KoiEmulator {
        public KoiEmulator(RhydonContext ctx, MethodExport export) {
            _ctx = ctx;
            _exp = export;
            _handlers = new Dictionary<KoiOpCodes, IKoiHandler>();
            _emuCtx = new EmuContext(_ctx, _exp);

            _ctx.Reader.BaseStream.Position = export.Offset;

            foreach (var h in typeof(KoiEmulator).Assembly.DefinedTypes
                .Where(t => !t.IsInterface && typeof(IKoiHandler).IsAssignableFrom(t))
                .Select(Activator.CreateInstance).Cast<IKoiHandler>().ToArray()) {
                if (_handlers.ContainsKey(h.Handles))
                {
                    _handlers[h.Handles] = h;
                }
                else
                {
                    _handlers.Add(h.Handles, h);
                }
                //_handlers.Add(h.Handles, h);
            }
        }

        readonly RhydonContext _ctx;
        readonly EmuContext _emuCtx;
        readonly MethodExport _exp;
        readonly Dictionary<KoiOpCodes, IKoiHandler> _handlers;

        public void EmulateNext() {
            var reader = _ctx.Reader;
            var code = _ctx.Map[reader.ReadKoiByte(_exp)];

            reader.ReadKoiByte(_exp); //For "key fixup" according Koi source...

            _ctx.Logger.Debug(code.ToString());
            _handlers[code].Emulate(_emuCtx);
        }
    }
}
