using dnlib.DotNet;

namespace Rhydon.Core {
    public static class Resolver {
        public static void ResolveAssemblies(RhydonContext ctx) {
            var mod = ctx.Module;

            var resolver = new AssemblyResolver();
            var modctx = new ModuleContext(resolver);

            resolver.DefaultModuleContext = modctx;
            resolver.EnableTypeDefCache = true;

            ctx.Logger.Info("Resolving dependencies...");
            foreach (var dep in mod.GetAssemblyRefs()) {
                var asm = resolver.ResolveThrow(dep, mod);
                ctx.Logger.Info($"Resolved {asm.Name}");
            }

            ctx.Module.Context = modctx;
        }
    }
}
