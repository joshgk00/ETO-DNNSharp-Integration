using Newtonsoft.Json;

namespace Eto.Parser.Entities.TouchPoint
{
    public class ElementAttribute
    {
        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}