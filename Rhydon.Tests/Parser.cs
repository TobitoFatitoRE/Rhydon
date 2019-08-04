using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhydon.Core;
using Rhydon.Core.Parser;

namespace Rhydon.Tests {
    [TestClass]
    public class Parser {
        [TestMethod]
        public void TestNoKoiHeader() {
            var mod = new ModuleDefUser("test");
            var ms = new MemoryStream();
            mod.Write(ms);

            var ctx = new RhydonContext { Module = ModuleDefMD.Load(ms), Logger = new DummyLogger() };
            KoiHeader.Parse(ctx);
            Assert.IsNull(ctx.Header);

            ms.Close();
        }

        [TestMethod]
        public void TestValidOpCodeMap() {
            var random = new Random();

            var mod = new ModuleDefUser("test");
            var type = new TypeDefUser("Constants");
            for (var i = 0; i < 119; i++)
                type.Fields.Add(new FieldDefUser("randomName" + random.Next(), new FieldSig(mod.CorLibTypes.Byte)));

            mod.Types.Add(type);

            var ctor = type.FindOrCreateStaticConstructor();
            var body = new CilBody();
            for (var i = 1; i < 119; i++) {
                body.Instructions.Insert(0, Instruction.Create(OpCodes.Stfld, type.Fields[i]));
                body.Instructions.Insert(0, Instruction.Create(OpCodes.Ldc_I4, random.Next(0, 0xFF)));
                body.Instructions.Insert(0, Instruction.Create(OpCodes.Ldnull));
            }

            body.Instructions.Add(Instruction.Create(OpCodes.Ldnull));
            body.Instructions.Add(Instruction.Create(OpCodes.Ldc_I4, 112));
            body.Instructions.Add(Instruction.Create(OpCodes.Stfld, type.Fields[0]));
            body.Instructions.Add(Instruction.Create(OpCodes.Ret));
            ctor.Body = body;

            var ms = new MemoryStream();
            mod.Write(ms);

            var ctx = new RhydonContext { Module = ModuleDefMD.Load(ms), Logger = new DummyLogger() };
            OpCodeMap.Parse(ctx);
            Assert.IsNotNull(ctx.Constants);
            Assert.IsTrue(ctx.Constants.REG_R0 == 112);

            ms.Close();
        }

        [TestMethod]
        public void TestInvalidOpCodeMap() {
            var random = new Random();

            var mod = new ModuleDefUser("test");
            var type = new TypeDefUser("Constants");
            for (var i = 0; i < random.Next(0, 100); i++)
                type.Fields.Add(new FieldDefUser("randomName" + random.Next(), new FieldSig(mod.CorLibTypes.Byte)));

            mod.Types.Add(type);

            var ms = new MemoryStream();
            mod.Write(ms);

            var ctx = new RhydonContext { Module = ModuleDefMD.Load(ms), Logger = new DummyLogger() };
            OpCodeMap.Parse(ctx);
            Assert.IsNull(ctx.Constants);
        }
    }
}
