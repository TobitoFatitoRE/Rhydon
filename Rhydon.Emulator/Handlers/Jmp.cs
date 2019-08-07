namespace Rhydon.Emulator.Handlers {
    class Jmp : KoiHandler {
        public Jmp(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_JMP;
        internal override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            ctx.Reader.BaseStream.Position = (long)slot.U8;
        }
    }

    class Jnz : KoiHandler {
        public Jnz(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_JNZ;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Jz : KoiHandler {
        public Jz(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_JZ;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }

    class Swt : KoiHandler {
        public Swt(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SWT;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
