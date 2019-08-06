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
            ulong num2 = (ulong)ctx.ReadByte();
            num2 |= (ulong)ctx.ReadByte() << 8;
            num2 |= (ulong)ctx.ReadByte() << 16;
            num2 |= (ulong)ctx.ReadByte() << 24;
            int lol = int.MinValue;
            ulong num3 = ((num2 & (ulong)lol) != 0UL) ? 18446744069414584320UL : 0UL;
            VMSlot newslot = new VMSlot();
            newslot.U8 = (num3 | num2);
            ctx.Stack.Push(newslot);
        }
    }

    class PushIQword : KoiHandler {
        public PushIQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHI_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ulong num2 = (ulong)ctx.ReadByte();
            num2 |= (ulong)ctx.ReadByte() << 8;
            num2 |= (ulong)ctx.ReadByte() << 16;
            num2 |= (ulong)ctx.ReadByte() << 24;
            num2 |= (ulong)ctx.ReadByte() << 32;
            num2 |= (ulong)ctx.ReadByte() << 40;
            num2 |= (ulong)ctx.ReadByte() << 48;
            num2 |= (ulong)ctx.ReadByte() << 56;
            ctx.Stack.Push(new VMSlot() { U8 = num2});

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
            byte b = ctx.ReadByte();
            VMSlot value = ctx.Registers[(int)b];
            ctx.Stack.Push(value);
        }
    }

    class PushRQword : KoiHandler {
        public PushRQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_PUSHR_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            byte b = ctx.ReadByte();
            VMSlot vmslot = ctx.Registers[(int)b];
            ctx.Stack.Push(new VMSlot() { U8 = vmslot.U8 });
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
