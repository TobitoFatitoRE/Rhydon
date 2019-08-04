namespace Rhydon.Emulator {
    abstract class KoiHandler {
        protected KoiHandler(EmuContext ctx) {
            Ctx = ctx;
        }

        internal readonly EmuContext Ctx;
        internal virtual byte Handles { get; }
        internal virtual void Emulate(EmuContext ctx) { }
        public override string ToString() => GetType().Name;
    }
}
