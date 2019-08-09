using System;
using System.Collections.Generic;
using System.Text;

namespace Rhydon.Emulator {
    internal interface IValueTypeBox {
        object GetValue();
        Type GetValueType();
        IValueTypeBox Clone();
    }
}
