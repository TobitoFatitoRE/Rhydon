using System;
using System.Collections.Generic;
using System.Text;

namespace Rhydon.Emulator {
    interface IReference {
        //VMSlot GetValue(EmuContext ctx, PointerType type);
        //void SetValue(EmuContext ctx, VMSlot slot, PointerType type);
        IReference Add(uint value);
        IReference Add(ulong value);
        //void ToTypedReference(EmuContext ctx, TypedRefPtr typedRef, Type type);
        // for now i removed the not needed stuff since they dont get used on the crackmes at all.
    }
}
