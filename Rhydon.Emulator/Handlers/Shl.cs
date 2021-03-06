﻿namespace Rhydon.Emulator.Handlers {
    class ShlDword : KoiHandler {
        public ShlDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SHL_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { U4 = (slot.U4 << (int)slot2.U4) });
        }
    }

    class ShlQword : KoiHandler {
        public ShlQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SHL_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { U8 = (slot.U8 << (int)slot2.U4) });
        }
    }
}
