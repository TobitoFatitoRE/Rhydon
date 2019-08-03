using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            Registers = new VMSlot[16];
            Handlers = new Dictionary<KoiOpCodes, IKoiHandler>();
        }

        internal RhydonContext Context;
        internal MethodExport Export;
        internal BinaryReader Reader;
        internal List<KoiInstruction> MethodBody;
        internal Stack<VMSlot> Stack;
        internal VMSlot[] Registers;
        internal Dictionary<KoiOpCodes, IKoiHandler> Handlers;

        internal IKoiHandler Lookup(byte code) =>
            Handlers[Context.Map[code]];

        internal byte Lookup(KoiOpCodes code) =>
            Context.Map.First(p => p.Value == code).Key;

        internal byte ReadByte() =>
            Reader.ReadKoiByte(Export);
    }
}
