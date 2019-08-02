using System.Drawing;
using Colorful;
using dnlib.DotNet;
using Rhydon.Core;
using Rhydon.Core.Parser;
using Rhydon.Emulator;
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
            KoiHeader.Parse(ctx);
            OpCodeMap.Parse(ctx);

            var emu = new KoiEmulator(ctx, ctx.Header.Methods[4]);
            emu.EmulateNext();

            Console.ReadLine();
        }

        public class Logger : ILogger {
            public void Debug(string message) {
                Console.WriteLine("[-] " + message, Color.DarkGray);
            }

            public void Info(string message) {
                Console.WriteLine("[*] " + message, Color.White);
            }

            public void Warning(string message) {
                Console.WriteLine("[!] " + message, Color.OrangeRed);
            }

            public void Error(string message) {
                Console.WriteLine("[#] " + message, Color.Red);
            }

            public void Success(string message) {
                Console.WriteLine("[+] " + message, Color.Lime);
            }
        }
    }
}
