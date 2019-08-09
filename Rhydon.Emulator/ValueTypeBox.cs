using System;
using System.Collections.Generic;
using System.Text;

namespace Rhydon.Emulator {
    internal struct ValueTypeBox<T> : IValueTypeBox {
     
        public ValueTypeBox(T value) {
            this.value = value;
        }

     
        public object GetValue() {
            return this.value;
        }

       
        public Type GetValueType() {
            return typeof(T);
        }

   
        public IValueTypeBox Clone() {
            return new ValueTypeBox<T>(this.value);
        }

       
        private readonly T value;
    }
}
