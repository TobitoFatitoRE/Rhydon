using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rhydon.Core.Parser {
    public static class OpCodeMap {
        public static Dictionary<byte, KoiOpCodes> Parse(RhydonContext ctx) {
            var map = new Dictionary<byte, KoiOpCodes>();

            var constantstype = ctx.Module.Types.SingleOrDefault(t => t.HasFields && t.Fields.Count == 119);
            if (constantstype == null)
                return null;
            
            var fields = constantstype.Fields.OrderBy(f => f.MDToken.Raw).ToList();
            var ctor = constantstype.FindStaticConstructor().Body.Instructions;
            for (var i = 1; i < ctor.Count; i++) {
                var curr = ctor[i];
                if (curr.OpCode != OpCodes.Stfld)
                    continue;

                var constant = (FieldDef)curr.Operand;
                var value = (byte)ctor[i - 1].GetLdcI4Value();

                map[value] = (KoiOpCodes)fields.IndexOf(constant);
            }

            return map;
        }
    }
}
