using System;

namespace Rhydon.Emulator.Handlers {
    class SindByte : KoiHandler {
        public SindByte(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_BYTE;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            var slot2 = ctx.Stack.Pop();
            if (slot.O is IReference) {
               ((IReference)slot.O).SetValue(ctx,slot2, PointerType.BYTE);
            } else {
                byte u2 = slot2.U1;
                byte* ptr = (byte*)slot.U8;
                *ptr = u2;
            }
        }
    }

    class SindDword : KoiHandler {
        public SindDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_DWORD;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            var slot2 = ctx.Stack.Pop();
            if (slot.O is IReference) {
                ((IReference)slot.O).SetValue(ctx, slot2, PointerType.DWORD);
            } else {
                uint u2 = slot2.U4;
                uint* ptr = (uint*)slot.U8;
                *ptr = u2;
            }
        }
    }

    class SindObject : KoiHandler {
        public SindObject(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_OBJECT;
        internal override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            var slot2 = ctx.Stack.Pop();
            if (slot.O is IReference) {
                ((IReference)slot.O).SetValue(ctx, slot2, PointerType.OBJECT);
            } else {
                //Throw Exception?
            }
        }
    }

    class SindPtr : KoiHandler {
        public SindPtr(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_PTR;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            var slot2 = ctx.Stack.Pop();
            if (slot.O is IReference) {
                ((IReference)slot.O).SetValue(ctx, slot2, IntPtr.Size == 8 ? PointerType.QWORD : PointerType.DWORD);
            } else {
                if (IntPtr.Size == 8) {
                    ulong* ptr = (ulong*)slot.U8;
                    *ptr = slot2.U8;
                } else {
                    uint* ptr2 = (uint*)slot.U8;
                    *ptr2 = slot2.U4;
                }
            }
        }
    }

    class SindQword : KoiHandler {
        public SindQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_QWORD;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            var slot2 = ctx.Stack.Pop();
            if (slot.O is IReference) {
                ((IReference)slot.O).SetValue(ctx, slot2, PointerType.QWORD);
            } else {
                ulong u2 = slot2.U8;
                ulong* ptr = (ulong*)slot.U8;
                *ptr = u2;
            }
        }
    }

    class SindWord : KoiHandler {
        public SindWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_SIND_WORD;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            var slot2 = ctx.Stack.Pop();
            if (slot.O is IReference) {
                ((IReference)slot.O).SetValue(ctx, slot2, PointerType.WORD);
            } else {
                ushort u2 = slot2.U2;
                ushort* ptr = (ushort*)slot.U8;
                *ptr = u2;
            }
        }
    }
}
