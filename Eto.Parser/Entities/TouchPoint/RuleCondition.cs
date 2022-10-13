using Newtonsoft.Json;

namespace Eto.Parser.Entities.TouchPoint
{
    public class RuleCondition
    {
        [JsonProperty("FormElementID")]
        public int FormElementID { get; set; }

        [JsonProperty("FormRuleConditionEQElementValue")]
        public object FormRuleConditionEQElementValue { get; set; }

        [JsonProperty("FormRuleConditionElementValue")]
        public object FormRuleConditionElementValue { get; set; }

        [JsonProperty("MeasurementNonNumeric")]
        public int? MeasurementNonNumeric { get; set; }

        [JsonProperty("MeasurementNumeric")]
        public int? MeasurementNumeric { get; set; }

        [JsonProperty("OperationRequired")]
        public int OperationRequired { get; set; }

        [JsonProperty("SequenceOrder")]
        public int SequenceOrder { get; set; }

        [JsonProperty("SourceFormRuleConditionID")]
        public object SourceFormRuleConditionID { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}