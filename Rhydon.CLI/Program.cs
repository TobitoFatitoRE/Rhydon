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

            var emu = new KoiEmulator(ctx, ctx.Header.Methods[3]);
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();
            emu.EmulateNext();

            ctx.Logger.Warning("Warning");
            ctx.Logger.Error("Error");

            Console.ReadLine();
        }

        public class Logger : ILogger {
            internal Logger() {
                _sheet = new StyleSheet(Color.White);
                _sheet.AddStyle("(?<=\\[)\\-(?=\\])", Color.DarkGray);
                _sheet.AddStyle("(?<=\\[)\\*(?=\\])", Color.Cyan);
                _sheet.AddStyle("(?<=\\[)\\!(?=\\])", Color.OrangeRed);
                _sheet.AddStyle("(?<=\\[)\\#(?=\\])", Color.Red);
                _sheet.AddStyle("(?<=\\[)\\+(?=\\])", Color.Lime);
            }

            private readonly StyleSheet _sheet;

            void Log(string message) =>
                Console.WriteLineStyled(message, _sheet);

            public void Debug(string message) =>
                Log($"[-] {message}");

            public void Info(string message) =>
                Log($"[*] {message}");

            public void Warning(string message) =>
                Log($"[!] {message}");

            public void Error(string message) =>
                Log($"[#] {message}");

            public void Success(string message) =>
                Log($"[+] {message}");
        }
    }
}
