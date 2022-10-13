using Newtonsoft.Json;

namespace Eto.Parser.Entities.Demographics
{
    public class DefinedTextValue
    {
        [JsonProperty("CDID")]
        public int CDID { get; set; }

        [JsonProperty("Disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("Sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }
    }
}