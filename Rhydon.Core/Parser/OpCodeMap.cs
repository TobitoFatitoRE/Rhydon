using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rhydon.Core.Parser {
    public class OpCodeMap : Dictionary<byte, KoiOpCodes> {
        public static OpCodeMap Parse(RhydonContext ctx) {
            var constantstype = ctx.Module.Types.SingleOrDefault(t => t.HasFields && t.Fields.Count == 119);
            if (constantstype == null)
                return null;
            
            var map = new OpCodeMap();
            var fields = constantstype.Fields.OrderBy(f => f.MDToken.Raw).ToList();
            var ctor = constantstype.FindStaticConstructor();
            if (ctor == null)
                return null;

            var body = ctor.Body.Instructions;
            for (var i = 1; i < body.Count; i++) {
                var curr = body[i];
                if (curr.OpCode != OpCodes.Stfld)
                    continue;

                var constant = (FieldDef)curr.Operand;
                var value = (byte)body[i - 1].GetLdcI4Value();

                map[value] = (KoiOpCodes)fields.IndexOf(constant);
            }

            return map;
        }
    }
}
