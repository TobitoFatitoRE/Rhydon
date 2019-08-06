namespace Rhydon.Emulator.Handlers {
    class SxByte : KoiHandler {
        public SxByte(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SX_BYTE;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot value = ctx.Stack.Pop();
            bool flag = (value.U1 & 128) > 0;
            if (flag) {
                value.U4 = ((uint)value.U1 | 4294967040u);
            }
            ctx.Stack.Push(value);
        }
    }

    class SxDword : KoiHandler {
        public SxDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SX_DWORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot value = ctx.Stack.Pop() ;
            bool flag = (value.U4 & 2147483648u) > 0u;
            if (flag) {
                value.U8 = (18446744069414584320UL | (ulong)value.U4);
            }
            ctx.Stack.Push(value);
        }
    }

    class SxWord : KoiHandler {
        public SxWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SX_WORD;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            VMSlot value = ctx.Stack.Pop();
            bool flag = (value.U2 & 32768) > 0;
            if (flag) {
                value.U4 = ((uint)value.U2 | 4294901760u);
            }
            ctx.Stack.Push(value);
        }
    }
}
