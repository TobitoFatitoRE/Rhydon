using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rhydon.Core.Parser {
    public class VirtualizedMethods {
        public static void Parse(RhydonContext ctx) {
            var VirtedMethods = new Dictionary<int, MethodDef>();
            var VirtedMethods2 = new Dictionary<int, MethodDef>();
            foreach (var type in ctx.Module.Types) {
                foreach(var method in type.Methods) {
                    if(method.HasBody && method.Body.HasInstructions && method.Body.Instructions.Count() >= 6) {
                       if(IsVirtedMethod(method)) {
                            ctx.Logger.Info("Found Virtualized Method " + method.FullName + " With ID " + method.Body.Instructions[1].GetLdcI4Value());
                            VirtedMethods.Add(method.Body.Instructions[1].GetLdcI4Value(),method);
                        }
                    }
                }
            }
           var methods = VirtedMethods.OrderBy(q => q.Key);
            foreach(var method in methods) {
                VirtedMethods2.Add(method.Key, method.Value);
            }
            ctx.VirtualizedMethods = VirtedMethods2; 
          
        }
        public static bool IsVirtedMethod(MethodDef method) {
            if(method.Body.Instructions[0].OpCode == OpCodes.Ldtoken) {
                if (method.Body.Instructions[1].IsLdcI4()) {
                    if (method.Body.Instructions[2].IsLdcI4()) {
                        var Instr = method.Body.Instructions.Where(q => q.OpCode == OpCodes.Call).ToArray();
                        if(Instr.Count() >= 1) {
                            if(Instr[0].ToString().Contains("(System.RuntimeTypeHandle,System.UInt32,System.Object[])")) {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
