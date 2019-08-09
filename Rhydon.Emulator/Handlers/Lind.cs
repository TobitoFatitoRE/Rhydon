using System;

namespace Rhydon.Emulator.Handlers {
    class LindByte : KoiHandler {
        public LindByte(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_BYTE;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            VMSlot value = new VMSlot();
            if(slot.O is IReference) {
                value = ((IReference)slot.O).GetValue(ctx, PointerType.BYTE);
            } else {
                byte* ptr = (byte*)slot.U8;
                value = new VMSlot {
                    U1 = *ptr
                };
            }
            ctx.Stack.Push(value);
        }
    }

    class LindDword : KoiHandler {
        public LindDword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_DWORD;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            VMSlot value = new VMSlot();
            if (slot.O is IReference) {
                value = ((IReference)slot.O).GetValue(ctx, PointerType.DWORD);
            } else {
                uint* ptr = (uint*)slot.U8;
                value = new VMSlot {
                    U4 = *ptr
                };
            }
            ctx.Stack.Push(value);
        }
    }

    class LindObject : KoiHandler {
        public LindObject(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_OBJECT;
        internal override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            VMSlot value = new VMSlot();
            if (slot.O is IReference) {
                value = ((IReference)slot.O).GetValue(ctx, PointerType.OBJECT);
            } else {
                //throw exception?
            }
            ctx.Stack.Push(value);
        }
    }

    class LindPtr : KoiHandler {
        public LindPtr(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_PTR;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            VMSlot value = new VMSlot();
            if (slot.O is IReference) {
                value = ((IReference)slot.O).GetValue(ctx, IntPtr.Size == 8 ? PointerType.QWORD : PointerType.DWORD);
            } else {
                if(IntPtr.Size == 8) {
                    ulong* ptr = (ulong*)slot.U8;
                    value = new VMSlot {
                        U8 = *ptr
                    };
                } else {
                    uint* ptr = (uint*)slot.U8;
                    value = new VMSlot {
                        U4 = *ptr
                    };
                }
               
            }
            ctx.Stack.Push(value);
        }
    }

    class LindQword : KoiHandler {
        public LindQword(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_QWORD;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            VMSlot value = new VMSlot();
            if (slot.O is IReference) {
                value = ((IReference)slot.O).GetValue(ctx, PointerType.QWORD);
            } else {
                ulong* ptr = (ulong*)slot.U8;
                value = new VMSlot {
                    U8 = *ptr
                };
            }
            ctx.Stack.Push(value);
        }
    }

    class LindWord : KoiHandler {
        public LindWord(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.OP_LIND_WORD;
        internal unsafe override void Emulate(EmuContext ctx) {
            var slot = ctx.Stack.Pop();
            VMSlot value = new VMSlot();
            if (slot.O is IReference) {
                value = ((IReference)slot.O).GetValue(ctx, PointerType.WORD);
            } else {
                ushort* ptr = (ushort*)slot.U8;
                value = new VMSlot {
                    U2 = *ptr
                };
            }
            ctx.Stack.Push(value);
        }
    }
}
