using System.IO;
using Rhydon.Core;
using Rhydon.Core.Parser;

namespace Rhydon.Emulator {
    class EmuContext {
        internal EmuContext(RhydonContext ctx, MethodExport exp) {
            Context = ctx;
            Export = exp;
            Reader = ctx.Reader;
        }

        internal RhydonContext Context;
        internal MethodExport Export;
        internal BinaryReader Reader;
    }
}
