using System.Collections.Generic;

namespace Rhydon.Core {
    public class OptionalParameters {
        readonly Dictionary<string, object> _params;
        public OptionalParameters() => _params = new Dictionary<string, object>();

        public object this[string i, object def = null] {
            get => _params.TryGetValue(i, out var returnValue) ? returnValue : def;
            set => _params[i] = value;
        }
    }
}
