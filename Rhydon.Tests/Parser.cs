using System.IO;
using dnlib.DotNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhydon.Core;
using Rhydon.Core.HeapParser;

namespace Rhydon.Tests {
    [TestClass]
    public class Parser {
        [TestMethod]
        public void TestNoKoiHeader() {
            var mod = new ModuleDefUser("test");
            var ms = new MemoryStream();
            mod.Write(ms);

            var ctx = new RhydonContext { Module = ModuleDefMD.Load(ms) };
            var header = new KoiHeader(ctx);
            Assert.IsFalse(header.Good);

            ms.Close();
        }
    }
}
