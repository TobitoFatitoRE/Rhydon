using Rhydon.Core;

namespace Rhydon.Emulator.Handlers {
    class PushRDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_PUSHR_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushIDword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_PUSHI_DWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushIQword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_PUSHI_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushRByte : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_PUSHR_BYTE;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushRObject : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_PUSHR_OBJECT;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushRQword : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_PUSHR_QWORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }

    class PushRWord : IKoiHandler {
        public KoiOpCodes Handles => KoiOpCodes.OP_PUSHR_WORD;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
            ctx.Reader.ReadKoiByte(ctx.Export); // ReadByte gets used on original opcode.
        }
    }
}
