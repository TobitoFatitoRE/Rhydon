using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class PushRDword : KoiHandler {
        internal PushRDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_DWORD;
        public void Emulate(EmuContext ctx) {
            var regid = ctx.ReadByte();
            var slot = ctx.Registers[regid];

            if (regid == ctx.Lookup(Ctx.Constants.REG_SP) || regid == ctx.Lookup(Ctx.Constants.REG_BP))
                ctx.Stack.Push(VMSlot.Null); //TODO: StackRef
            else ctx.Stack.Push(new VMSlot { U4 = slot.U4 });
        }
    }

    class PushIDword : KoiHandler {
        internal PushIDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHI_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
          
        }
    }

    class PushIQword : KoiHandler {
        internal PushIQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHI_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.

        }
    }

    class PushRByte : KoiHandler {
        internal PushRByte(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_BYTE;
        public void Emulate(EmuContext ctx) {
            var regid = ctx.ReadByte();
            var slot = ctx.Registers[regid];
            ctx.Stack.Push(new VMSlot { U1 = slot.U1 });
        }
    }

    class PushRObject : KoiHandler {
        internal PushRObject(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_OBJECT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushRQword : KoiHandler {
        internal PushRQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushRWord : KoiHandler {
        internal PushRWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_WORD;
        public void Emulate(EmuContext ctx) {
            var regid = ctx.ReadByte();
            var slot = ctx.Registers[regid];

            ctx.Stack.Push(new VMSlot { U2 = slot.U2 });
        }
    }
}
