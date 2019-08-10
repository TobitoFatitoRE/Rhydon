using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace Rhydon.Emulator {
    internal class TypedRef : IReference {
        public TypedRef(TypedRefPtr ptr) {
            this._ptr = new TypedRefPtr?(ptr);
        }

     
        public unsafe TypedRef(TypedReference typedRef) {
            this._ptr = null;
            this._typedRef = *(TypedRef.PseudoTypedRef*)(&typedRef);
        }


        public unsafe VMSlot GetValue(EmuContext ctx, PointerType type) {
            bool flag = this._ptr != null;
            TypedReference typedReference;
            if (flag) {
                *(&typedReference) = *(TypedReference*)this._ptr.Value;
            } else {
                *(TypedRef.PseudoTypedRef*)(&typedReference) = this._typedRef;
            }
            return VMSlot.FromObject(TypedReference.ToObject(typedReference), __reftype(typedReference));
        }

       
        public unsafe void SetValue(EmuContext ctx, VMSlot slot, PointerType type) {
            bool flag = this._ptr != null;
            TypedReference typedReference;
            if (flag) {
                *(&typedReference) = *(TypedReference*)this._ptr.Value;
            } else {
                *(TypedRef.PseudoTypedRef*)(&typedReference) = this._typedRef;
            }
            Type typeFromHandle = __reftype(typedReference);
            object value = slot.ToObject(typeFromHandle);
            Helpers.TypedReferenceHelpers.SetTypedRef(value, (void*)(&typedReference));
        }

        
        public IReference Add(uint value) {
            return this;
        }


        public IReference Add(ulong value) {
            return this;
        }

        
        public unsafe void ToTypedReference(EmuContext ctx, TypedRefPtr typedRef, Type type) {
            bool flag = this._ptr != null;
            if (flag) {
                *(TypedReference*)typedRef = *(TypedReference*)this._ptr.Value;
            } else {
                *(TypedRef.PseudoTypedRef*)typedRef = this._typedRef;
            }
        }

      
        private TypedRefPtr? _ptr;


        private readonly TypedRef.PseudoTypedRef _typedRef;

        
        private struct PseudoTypedRef {
           
            public readonly IntPtr Type;

          
            public readonly IntPtr Value;
        }
    }
}
