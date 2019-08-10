using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Reflection;
namespace Rhydon.Emulator {
    internal class FieldRef : IReference {

        public FieldRef(object instance, FieldInfo field) {
            this.instance = instance;
            this.field = field;
        }

       
        public VMSlot GetValue(EmuContext ctx, PointerType type) {
            object obj = this.instance;
            bool flag = this.field.DeclaringType.IsValueType && this.instance is IReference;
            if (flag) {
                obj = ((IReference)this.instance).GetValue(ctx, PointerType.OBJECT).ToObject(this.field.DeclaringType);
            }
            return VMSlot.FromObject(this.field.GetValue(obj), this.field.FieldType);
        }


        public unsafe void SetValue(EmuContext ctx, VMSlot slot, PointerType type) {
            bool flag = this.field.DeclaringType.IsValueType && this.instance is IReference;
            if (flag) {
                TypedReference obj;
                ((IReference)this.instance).ToTypedReference(ctx, (void*)(&obj), this.field.DeclaringType);
                this.field.SetValueDirect(obj, slot.ToObject(this.field.FieldType));
            } else {
                this.field.SetValue(this.instance, slot.ToObject(this.field.FieldType));
            }
        }

      
        public IReference Add(uint value) {
            return this;
        }


        public IReference Add(ulong value) {
            return this;
        }

       
        public void ToTypedReference(EmuContext ctx, TypedRefPtr typedRef, Type type) {
            Rhydon.Emulator.Helpers.TypedReferenceHelpers.GetFieldAddr(ctx, this.instance, this.field, typedRef);
        }


        private readonly FieldInfo field;
 
        private readonly object instance;
    }
}
