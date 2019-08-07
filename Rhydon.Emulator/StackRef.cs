using System;
using System.Collections.Generic;
using System.Text;

namespace Rhydon.Emulator {
    class StackRef : IReference {
        public StackRef(uint pos) {
            this.StackPos = pos;
        }
        public uint StackPos { get; set; }
        public IReference Add(uint value) {
            return new StackRef(this.StackPos + value);
        }

        public IReference Add(ulong value) {
            return new StackRef(this.StackPos + (uint)value);
        }
    }
}
