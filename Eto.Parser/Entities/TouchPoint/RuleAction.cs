using Newtonsoft.Json;

namespace Eto.Parser.Entities.TouchPoint
{
    public class RuleAction
    {
        [JsonProperty("Action")]
        public int Action { get; set; }

        [JsonProperty("FormElementID")]
        public int FormElementID { get; set; }

        [JsonProperty("FormRuleID")]
        public int FormRuleID { get; set; }

        [JsonProperty("OperationRequired")]
        public int OperationRequired { get; set; }

        [JsonProperty("SequenceOrder")]
        public int SequenceOrder { get; set; }

        [JsonProperty("SourceFormRuleActionID")]
        public object SourceFormRuleActionID { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}