﻿namespace Rhydon.Emulator.Handlers.VCall {
    class Cast : KoiHandler {
        public Cast(EmuContext ctx) : base(ctx) { }

        internal override byte Handles => Ctx.Constants.VCALL_CAST;
        internal override void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
