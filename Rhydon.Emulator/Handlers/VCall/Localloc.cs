﻿using Rhydon.Core;
namespace Rhydon.Emulator.Handlers.VCall {
    class Localloc : KoiHandler {
        internal Localloc(EmuContext ctx) : base(ctx) { }
        internal override byte Handles => Ctx.Constants.VCALL_LOCALLOC;
        public void Emulate(EmuContext ctx) {
            //throw new System.NotImplementedException();
        }
    }
}
