using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections;
using System.Reflection.Emit;
using System.Reflection;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Permissions;
namespace Rhydon.Emulator {
    internal class SizeOfHelper {
        //System.Reflection.Emit doesnt have a lot of stuff :(
        public static int SizeOf(Type type) {
            object obj = SizeOfHelper.sizes[type];
            bool flag = obj == null;
            if (flag) {
                Hashtable obj2 = SizeOfHelper.sizes;
                lock (obj2) {
                    obj = SizeOfHelper.sizes[type];
                    bool flag2 = obj == null;
                    if (flag2) {
                        obj = SizeOfHelper.GetSize(type);
                        SizeOfHelper.sizes[type] = obj;
                    }
                }
            }
            return (int)obj;
        }

 
        private static int GetSize(Type type) {
             DynamicMethod dynamicMethod = new DynamicMethod("", typeof(int), Type.EmptyTypes, Unverifier.Module, true);
             ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
             ilgenerator.Emit(OpCodes.Sizeof, type);
             ilgenerator.Emit(OpCodes.Ret);
             return (int)dynamicMethod.Invoke(null, null);
        }

       
        private static readonly Hashtable sizes = new Hashtable();
    }
    internal static class Unverifier {
     
        static Unverifier() {
            AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("Fish"), AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("Fish");
            CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(typeof(SecurityPermissionAttribute).GetConstructor(new Type[]
            {
                typeof(SecurityAction)
            }), new object[]
            {
                SecurityAction.Assert
            }, new PropertyInfo[]
            {
                typeof(SecurityPermissionAttribute).GetProperty("SkipVerification")
            }, new object[]
            {
                true
            });
            moduleBuilder.SetCustomAttribute(customAttribute);
            Unverifier.Module = moduleBuilder.DefineType(" ").CreateTypeInfo().AsType().Module;
        }


        public static readonly Module Module;
    }
}
