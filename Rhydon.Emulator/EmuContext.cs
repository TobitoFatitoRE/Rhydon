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
            Handlers = new Dictionary<byte, KoiHandler>();

            Module = ctx.Module;
            Reader = ctx.Reader;
            Header = ctx.Header;
            StartOffset = ctx.StartOffset;
            Constants = ctx.Constants;
            Decompiled = ctx.Decompiled;
            Logger = ctx.Logger;
            Parameters = ctx.Parameters;
        }

        internal MethodExport Export { get; }
        internal List<KoiInstruction> MethodBody { get; }
        internal Stack<VMSlot> Stack { get; }
        internal VMSlot[] Registers { get; set; }
        internal Dictionary<byte, KoiHandler> Handlers { get; }

        internal KoiHandler Lookup(byte code) =>
            Handlers[code];
        
        internal byte ReadByte() =>
            Reader.ReadKoiByte(Export);
    }
}
