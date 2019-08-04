using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rhydon.Core.Parser {
    public class OpCodeMap {
        public static void Parse(RhydonContext ctx) {
            var constantstype = ctx.Module.Types.SingleOrDefault(t => t.HasFields && t.Fields.Count == 119);
            if (constantstype == null)
                return;
            
            var fields = constantstype.Fields.OrderBy(f => f.MDToken.Raw).ToList();
            var ctor = constantstype.FindStaticConstructor();
            if (ctor == null)
                return;

            var constants = new Constants();
            var body = ctor.Body.Instructions;
            var sortedconstants = constants.GetType().GetFields().OrderBy(f => f.MetadataToken).ToArray();
            for (var i = 1; i < body.Count; i++) {
                var curr = body[i];
                if (curr.OpCode != OpCodes.Stfld)
                    continue;

                var constant = (FieldDef)curr.Operand;
                var value = (byte)body[i - 1].GetLdcI4Value();

                sortedconstants[fields.IndexOf(constant)].SetValue(constants, value);
            }

            ctx.Constants = constants;
        }
    }
}
