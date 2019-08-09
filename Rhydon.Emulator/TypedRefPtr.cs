using System;
using System.Collections.Generic;
using System.Text;

namespace Rhydon.Emulator {
    internal struct TypedRefPtr {
        public unsafe static implicit operator TypedRefPtr(void* ptr) {
            return new TypedRefPtr {
                ptr = ptr
            };
        }
        public unsafe static implicit operator void*(TypedRefPtr ptr) {
            return ptr.ptr;
        }
        public unsafe void* ptr;
    }
}
