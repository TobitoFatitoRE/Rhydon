using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class Jmp : KoiHandler {
        internal Jmp(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_JMP;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Jnz : KoiHandler {
        internal Jnz(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_JNZ;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Jz : KoiHandler {
        internal Jz(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_JZ;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Swt : KoiHandler {
        internal Swt(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SWT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
