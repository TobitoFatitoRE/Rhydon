namespace Rhydon.Emulator.Handlers {
    class RemDword : KoiHandler {
        public RemDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { U4 = (slot.U4 % slot2.U4) });
        }
    }

    class RemQword : KoiHandler {
        public RemQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { U8 = (slot.U8 % slot2.U8) });
        }
    }

    class RemR32 : KoiHandler {
        public RemR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R4 = (slot.R4 % slot2.R4) });
        }
    }

    class RemR64 : KoiHandler {
        public RemR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_REM_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot slot = ctx.Stack.Pop();
            VMSlot slot2 = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R8 = (slot.R8 % slot2.R8) });
        }
    }
}
