using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class PushRDword : KoiHandler {
        public PushRDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_DWORD;
        internal override void Emulate(EmuContext ctx) {
            var regid = ctx.ReadByte();
            var slot = ctx.Registers[regid];

            if (regid == ctx.Constants.REG_SP || regid == Ctx.Constants.REG_BP)
                ctx.Stack.Push(VMSlot.Null); //TODO: StackRef
            else ctx.Stack.Push(new VMSlot { U4 = slot.U4 });
        }
    }

    class PushIDword : KoiHandler {
        public PushIDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHI_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
          
        }
    }

    class PushIQword : KoiHandler {
        public PushIQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHI_QWORD;
        internal override void Emulate(EmuContext ctx) {
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
        public PushRByte(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_BYTE;
        internal override void Emulate(EmuContext ctx) {
            var regid = ctx.ReadByte();
            var slot = ctx.Registers[regid];
            ctx.Stack.Push(new VMSlot { U1 = slot.U1 });
        }
    }

    class PushRObject : KoiHandler {
        public PushRObject(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_OBJECT;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushRQword : KoiHandler {
        public PushRQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushRWord : KoiHandler {
        public PushRWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_WORD;
        internal override void Emulate(EmuContext ctx) {
            var regid = ctx.ReadByte();
            var slot = ctx.Registers[regid];

            ctx.Stack.Push(new VMSlot { U2 = slot.U2 });
        }
    }
}
