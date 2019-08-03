using System.Collections.Generic;
using System.IO;
using Rhydon.Core;
using Rhydon.Core.Parser;

namespace Rhydon.Emulator {
    class EmuContext {
        internal EmuContext(RhydonContext ctx, MethodExport exp) {
            Context = ctx;
            Export = exp;
            Reader = ctx.Reader;
            MethodBody = new List<KoiInstruction>();
            Stack = new Stack<VMSlot>();
            Handlers = new Dictionary<KoiOpCodes, IKoiHandler>();
        }

        internal RhydonContext Context;
        internal MethodExport Export;
        internal BinaryReader Reader;
        internal List<KoiInstruction> MethodBody;
        internal Stack<VMSlot> Stack;
        internal Dictionary<KoiOpCodes, IKoiHandler> Handlers;

        internal IKoiHandler Lookup(byte code) =>
            Handlers[Context.Map[code]];

        internal byte ReadByte() =>
            Reader.ReadKoiByte(Export);
    }
}
