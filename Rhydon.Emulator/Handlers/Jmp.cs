using System;

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
            var slot = ctx.Stack.Pop();
            var slot2 = ctx.Stack.Pop();
            if(slot2.U8 > 0UL)
            ctx.Reader.BaseStream.Position = (long)slot.U8;
        }
    }

    class Jz : KoiHandler {
        public Jz(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_JZ;
        internal override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            var slot2 = ctx.Stack.Pop();
            if (slot2.U8 == 0UL)
                ctx.Reader.BaseStream.Position = (long)slot.U8;
        }
    }

    class Swt : KoiHandler {
        public Swt(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SWT;
         internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            var slot2 = ctx.Stack.Pop();
            uint u = slot2.U4;
         //   ushort num2 = *(UIntPtr)(slot.U8 - 2UL);
         //   bool flag = u < (uint)num2;
        //    if (flag) {
        //        ctx.Reader.BaseStream.Position = ctx.Reader.BaseStream.Position + (ulong)((long)(*((UIntPtr)slot.U8 + (UIntPtr)((IntPtr)((ulong)u * 4UL)))));
        //    }
        //To Fix This
        }
    }
}
