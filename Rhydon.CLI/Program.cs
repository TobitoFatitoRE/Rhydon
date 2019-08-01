using System;
using dnlib.DotNet;
using Rhydon.Core;
using Rhydon.Core.Parser;
using ILogger = Rhydon.Core.ILogger;
using Resolver = Rhydon.Core.Resolver;

namespace Rhydon.CLI {
    class Program {
        static void Main() {
            var ctx = new RhydonContext {
                Module = ModuleDefMD.Load("Test.exe"),
                Logger = new Logger()
            };

            Resolver.ResolveAssemblies(ctx);
            ctx.Header = KoiHeader.Parse(ctx);
            ctx.Map = OpCodeMap.Parse(ctx);

            foreach (var (key, value) in ctx.Map) {
                Console.WriteLine($"{key:X2} : {value}");
            }
            Console.ReadLine();
        }

        public class Logger : ILogger {
            public void Debug(string message) {
                Console.WriteLine(message);
            }

            public void Info(string message) {
                Console.WriteLine(message);
            }

            public void Warning(string message) {
                Console.WriteLine(message);
            }

            public void Error(string message) {
                Console.WriteLine(message);
            }

            public void Success(string message) {
                Console.WriteLine(message);
            }
        }
    }
}
