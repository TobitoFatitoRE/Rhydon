using System.Collections.Generic;
using System.Linq;
using Rhydon.Core;
using Rhydon.Core.Parser;

namespace Rhydon.Emulator {
    class EmuContext : RhydonContext {
        internal EmuContext(RhydonContext ctx, MethodExport exp) {
            Export = exp;
            MethodBody = new List<KoiInstruction>();
            Stack = new Stack<VMSlot>();
            Registers = new VMSlot[16];
            Handlers = new Dictionary<KoiOpCodes, IKoiHandler>();

            Module = ctx.Module;
            Reader = ctx.Reader;
            Header = ctx.Header;
            StartOffset = ctx.StartOffset;
            Map = ctx.Map;
            Decompiled = ctx.Decompiled;
            Logger = ctx.Logger;
            Parameters = ctx.Parameters;
        }

        internal MethodExport Export { get; }
        internal List<KoiInstruction> MethodBody { get; }
        internal Stack<VMSlot> Stack { get; }
        internal VMSlot[] Registers { get; set; }
        internal Dictionary<KoiOpCodes, IKoiHandler> Handlers { get; }

        internal IKoiHandler Lookup(byte code) =>
            Handlers[Map[code]];

        internal byte Lookup(KoiOpCodes code) =>
            Map.First(p => p.Value == code).Key;

        internal byte ReadByte() =>
            Reader.ReadKoiByte(Export);
    }
}
