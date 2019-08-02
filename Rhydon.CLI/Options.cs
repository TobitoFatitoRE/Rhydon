using CommandLine;

namespace Rhydon.CLI {
    public class Options {
        [Option("verbose", Default = false, HelpText = "Prints more info (can clog up the Console!)")]
        public bool Verbose { get; set; }

        [Option("custom-heap-name", Default = "Koi", HelpText = "Sets the stream name, in case if it isn't Koi")]
        public string CustomHeapName { get; set; }
    }
}
