namespace Rhydon.Emulator.Handlers {
    class AddDWord : KoiHandler {
        public AddDWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot vmslot = ctx.Stack.Pop();
            VMSlot vmslot2 = ctx.Stack.Pop();
            VMSlot value = new VMSlot();
            if (vmslot.O is IReference) {
                value.O = ((IReference)vmslot.O).Add(vmslot2.U4);
            } else {
                if (vmslot2.O is IReference) {
                    value.O = ((IReference)vmslot2.O).Add(vmslot.U4);
                } else {
                    value.U4 = vmslot2.U4 + vmslot.U4;
                }
            }
            ctx.Stack.Push(value);
        }
    }

    class AddQWord : KoiHandler {
        public AddQWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_QWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot value = new VMSlot();
            VMSlot vmslot = ctx.Stack.Pop();
            VMSlot vmslot2 = ctx.Stack.Pop();
            if (vmslot.O is IReference) {
                value.O = ((IReference)vmslot.O).Add(vmslot2.U8);
            } else {
                if (vmslot2.O is IReference) {
                    value.O = ((IReference)vmslot2.O).Add(vmslot.U8);
                } else {
                    value.U8 = vmslot2.U8 + vmslot.U8;
                }
            }
            ctx.Stack.Push(value);

        }
    }

    class AddR32 : KoiHandler {
        public AddR32(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_R32;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot first = ctx.Stack.Pop();
            VMSlot second = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R4 = second.R4 + first.R4});
        }
    }

    class AddR64 : KoiHandler {
        public AddR64(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_ADD_R64;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot first = ctx.Stack.Pop();
            VMSlot second = ctx.Stack.Pop();
            ctx.Stack.Push(new VMSlot() { R8 = second.R8 + first.R8 });
        }
    }
}
