using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Rhydon.Emulator.Helpers {
    internal static class TypedReferenceHelpers {
       
        public unsafe static void CastTypedRef(TypedRefPtr typedRef, Type targetType) {
            Type targetType2 = TypedReference.GetTargetType(*(TypedReference*)typedRef);
            KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(targetType2, targetType);
            object obj = TypedReferenceHelpers.castHelpers[keyValuePair];
            bool flag = obj == null;
            if (flag) {
                Hashtable obj2 = TypedReferenceHelpers.castHelpers;
                lock (obj2) {
                    obj = TypedReferenceHelpers.castHelpers[keyValuePair];
                    bool flag2 = obj == null;
                    if (flag2) {
                        obj = TypedReferenceHelpers.BuildCastHelper(targetType2, targetType);
                        TypedReferenceHelpers.castHelpers[keyValuePair] = obj;
                    }
                }
            }
            ((TypedReferenceHelpers.Cast)obj)(typedRef);
        }

 
        public unsafe static void MakeTypedRef(void* ptr, TypedRefPtr typedRef, Type targetType) {
            object obj = TypedReferenceHelpers.makeHelpers[targetType];
            bool flag = obj == null;
            if (flag) {
                Hashtable obj2 = TypedReferenceHelpers.makeHelpers;
                lock (obj2) {
                    obj = TypedReferenceHelpers.makeHelpers[targetType];
                    bool flag2 = obj == null;
                    if (flag2) {
                        obj = TypedReferenceHelpers.BuildMakeHelper(targetType);
                        TypedReferenceHelpers.makeHelpers[targetType] = obj;
                    }
                }
            }
            ((TypedReferenceHelpers.Make)obj)(ptr, typedRef);
        }

        public static void UnboxTypedRef(object box, TypedRefPtr typedRef) {
            TypedReferenceHelpers.UnboxTypedRef(box, typedRef, box.GetType());
            bool flag = box is IValueTypeBox;
            if (flag) {
                TypedReferenceHelpers.CastTypedRef(typedRef, ((IValueTypeBox)box).GetValueType());
            }
        }


        public static void UnboxTypedRef(object box, TypedRefPtr typedRef, Type boxType) {
            object obj = TypedReferenceHelpers.unboxHelpers[boxType];
            bool flag = obj == null;
            if (flag) {
                Hashtable obj2 = TypedReferenceHelpers.unboxHelpers;
                lock (obj2) {
                    obj = TypedReferenceHelpers.unboxHelpers[boxType];
                    bool flag2 = obj == null;
                    if (flag2) {
                        obj = TypedReferenceHelpers.BuildUnboxHelper(boxType);
                        TypedReferenceHelpers.unboxHelpers[boxType] = obj;
                    }
                }
            }
            ((TypedReferenceHelpers.Unbox)obj)(box, typedRef);
        }


        public unsafe static void SetTypedRef(object value, TypedRefPtr typedRef) {
            Type targetType = TypedReference.GetTargetType(*(TypedReference*)typedRef);
            object obj = TypedReferenceHelpers.setHelpers[targetType];
            bool flag = obj == null;
            if (flag) {
                Hashtable obj2 = TypedReferenceHelpers.setHelpers;
                lock (obj2) {
                    obj = TypedReferenceHelpers.setHelpers[targetType];
                    bool flag2 = obj == null;
                    if (flag2) {
                        obj = TypedReferenceHelpers.BuildSetHelper(targetType);
                        TypedReferenceHelpers.setHelpers[targetType] = obj;
                    }
                }
            }
            ((TypedReferenceHelpers.Set)obj)(value, typedRef);
        }


        public unsafe static void GetFieldAddr(EmuContext context, object obj, FieldInfo field, TypedRefPtr typedRef) {
            object obj2 = TypedReferenceHelpers.fieldAddrHelpers[field];
            bool flag = obj2 == null;
            if (flag) {
                Hashtable obj3 = TypedReferenceHelpers.fieldAddrHelpers;
                lock (obj3) {
                    obj2 = TypedReferenceHelpers.fieldAddrHelpers[field];
                    bool flag2 = obj2 == null;
                    if (flag2) {
                        obj2 = TypedReferenceHelpers.BuildAddrHelper(field);
                        TypedReferenceHelpers.fieldAddrHelpers[field] = obj2;
                    }
                }
            }
            bool flag3 = obj == null;
            TypedReference typedReference;
            if (flag3) {
                typedReference = default(TypedReference);
            } else {
                bool flag4 = obj is IReference;
                if (flag4) {
                    ((IReference)obj).ToTypedReference(context, (void*)(&typedReference), field.DeclaringType);
                } else {
                    typedReference = __makeref(obj);
                    TypedReferenceHelpers.CastTypedRef((void*)(&typedReference), obj.GetType());
                }
            }
            ((TypedReferenceHelpers.FieldAdr)obj2)((void*)(&typedReference), typedRef);
        } // Token: 0x0600019C RID: 412 RVA: 0x0000AD9C File Offset: 0x00008F9C
        private static TypedReferenceHelpers.Cast BuildCastHelper(Type sourceType, Type targetType) {
            DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
            {
                typeof(TypedRefPtr)
            }, Unverifier.Module, true);
            ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
            ilgenerator.Emit(OpCodes.Ldarga, 0);
            ilgenerator.Emit(OpCodes.Ldfld, TypedReferenceHelpers.typedPtrField);
            ilgenerator.Emit(OpCodes.Dup);
            ilgenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
            ilgenerator.Emit(OpCodes.Refanyval, sourceType);
            ilgenerator.Emit(OpCodes.Mkrefany, targetType);
            ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
            ilgenerator.Emit(OpCodes.Ret);
            return (TypedReferenceHelpers.Cast)dynamicMethod.CreateDelegate(typeof(TypedReferenceHelpers.Cast));
        }


        private unsafe static TypedReferenceHelpers.Make BuildMakeHelper(Type targetType) {
            DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
            {
                typeof(void*),
                typeof(TypedRefPtr)
            }, Unverifier.Module, true);
            ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
            ilgenerator.Emit(OpCodes.Ldarga, 1);
            ilgenerator.Emit(OpCodes.Ldfld, TypedReferenceHelpers.typedPtrField);
            ilgenerator.Emit(OpCodes.Ldarg_0);
            ilgenerator.Emit(OpCodes.Mkrefany, targetType);
            ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
            ilgenerator.Emit(OpCodes.Ret);
            return (TypedReferenceHelpers.Make)dynamicMethod.CreateDelegate(typeof(TypedReferenceHelpers.Make));
        }

        
        private static TypedReferenceHelpers.Unbox BuildUnboxHelper(Type boxType) {
            DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
            {
                typeof(object),
                typeof(TypedRefPtr)
            }, Unverifier.Module, true);
            ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
            ilgenerator.Emit(OpCodes.Ldarga, 1);
            ilgenerator.Emit(OpCodes.Ldfld, TypedReferenceHelpers.typedPtrField);
            ilgenerator.Emit(OpCodes.Ldarg_0);
            ilgenerator.Emit(OpCodes.Unbox, boxType);
            ilgenerator.Emit(OpCodes.Mkrefany, boxType);
            ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
            ilgenerator.Emit(OpCodes.Ret);
            return (TypedReferenceHelpers.Unbox)dynamicMethod.CreateDelegate(typeof(TypedReferenceHelpers.Unbox));
        }

    
        private static TypedReferenceHelpers.Set BuildSetHelper(Type refType) {
            DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
            {
                typeof(object),
                typeof(TypedRefPtr)
            }, Unverifier.Module, true);
            ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
            ilgenerator.Emit(OpCodes.Ldarga, 1);
            ilgenerator.Emit(OpCodes.Ldfld, TypedReferenceHelpers.typedPtrField);
            ilgenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
            ilgenerator.Emit(OpCodes.Refanyval, refType);
            ilgenerator.Emit(OpCodes.Ldarg_0);
            ilgenerator.Emit(OpCodes.Unbox_Any, refType);
            ilgenerator.Emit(OpCodes.Stobj, refType);
            ilgenerator.Emit(OpCodes.Ret);
            return (TypedReferenceHelpers.Set)dynamicMethod.CreateDelegate(typeof(TypedReferenceHelpers.Set));
        }

        
        private static TypedReferenceHelpers.FieldAdr BuildAddrHelper(FieldInfo field) {
            DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[]
            {
                typeof(TypedRefPtr),
                typeof(TypedRefPtr)
            }, Unverifier.Module, true);
            ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
            bool isStatic = field.IsStatic;
            if (isStatic) {
                ilgenerator.Emit(OpCodes.Ldarga, 1);
                ilgenerator.Emit(OpCodes.Ldfld, TypedReferenceHelpers.typedPtrField);
                ilgenerator.Emit(OpCodes.Ldsflda, field);
                ilgenerator.Emit(OpCodes.Mkrefany, field.FieldType);
                ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
                ilgenerator.Emit(OpCodes.Ret);
            } else {
                ilgenerator.Emit(OpCodes.Ldarga, 1);
                ilgenerator.Emit(OpCodes.Ldfld, TypedReferenceHelpers.typedPtrField);
                ilgenerator.Emit(OpCodes.Ldarga, 0);
                ilgenerator.Emit(OpCodes.Ldfld, TypedReferenceHelpers.typedPtrField);
                ilgenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
                ilgenerator.Emit(OpCodes.Refanyval, field.DeclaringType);
                bool flag = !field.DeclaringType.IsValueType;
                if (flag) {
                    ilgenerator.Emit(OpCodes.Ldobj, field.DeclaringType);
                }
                ilgenerator.Emit(OpCodes.Ldflda, field);
                ilgenerator.Emit(OpCodes.Mkrefany, field.FieldType);
                ilgenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
                ilgenerator.Emit(OpCodes.Ret);
            }
            return (TypedReferenceHelpers.FieldAdr)dynamicMethod.CreateDelegate(typeof(TypedReferenceHelpers.FieldAdr));
        }


        private static readonly Hashtable castHelpers = new Hashtable();

     
        private static readonly Hashtable makeHelpers = new Hashtable();


        private static readonly Hashtable unboxHelpers = new Hashtable();

    
        private static readonly Hashtable setHelpers = new Hashtable();


        private static readonly Hashtable fieldAddrHelpers = new Hashtable();

     
        private static readonly FieldInfo typedPtrField = typeof(TypedRefPtr).GetFields()[0];


        private delegate void Cast(TypedRefPtr typedRef);


        private unsafe delegate void Make(void* ptr, TypedRefPtr typedRef);

        private delegate void Unbox(object box, TypedRefPtr typedRef);

        private delegate void Set(object value, TypedRefPtr typedRef);

        private delegate void FieldAdr(TypedRefPtr value, TypedRefPtr typedRef);

    }
}
