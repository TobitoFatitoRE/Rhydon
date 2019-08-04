namespace Rhydon.Emulator {
    abstract class VCallHandler {
        protected VCallHandler(EmuContext ctx) {
            Ctx = ctx;
        }

        internal readonly EmuContext Ctx;
        internal virtual byte VCall { get; }
        internal virtual void EmulateVCall(EmuContext ctx) { }
        public override string ToString() => GetType().Name;
    }
}
