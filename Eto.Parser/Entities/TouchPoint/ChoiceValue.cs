using Newtonsoft.Json;

namespace Eto.Parser.Entities.TouchPoint
{
    public class ChoiceValue
    {
        [JsonProperty("Choice")]
        public string Choice { get; set; }

        [JsonProperty("ChoiceHTML")]
        public string ChoiceHTML { get; set; }

        [JsonProperty("Disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("OperationRequired")]
        public int OperationRequired { get; set; }

        [JsonProperty("Sequence")]
        public int Sequence { get; set; }

        [JsonProperty("TouchPointElementChoiceID")]
        public int TouchPointElementChoiceID { get; set; }
    }
}