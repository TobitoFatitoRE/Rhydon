using System;
using dnlib.DotNet;
using Rhydon.Core;
using Rhydon.Core.HeapParser;
using ILogger = Rhydon.Core.ILogger;

namespace Rhydon.CLI {
    class Program {
        static void Main(string[] args) {
            var ctx = new RhydonContext();
            ctx.Module = ModuleDefMD.Load("Test.exe");
            ctx.Logger = new Logger();

            var header = new KoiHeader(ctx);
            Console.WriteLine(header.Good);
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
