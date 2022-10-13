using Newtonsoft.Json;
using System.Collections.Generic;

namespace Eto.Parser.Entities.TouchPoint
{
    public class FormRule
    {
        [JsonProperty("AllMustBeTrue")]
        public int AllMustBeTrue { get; set; }

        [JsonProperty("Locked")]
        public bool Locked { get; set; }

        [JsonProperty("OperationRequired")]
        public int OperationRequired { get; set; }

        [JsonProperty("RuleActions")]
        public List<RuleAction> RuleActions { get; set; }

        [JsonProperty("RuleConditions")]
        public List<RuleCondition> RuleConditions { get; set; }

        [JsonProperty("RuleName")]
        public string RuleName { get; set; }

        [JsonProperty("SequenceOrder")]
        public int SequenceOrder { get; set; }

        [JsonProperty("SourceFormRuleID")]
        public int SourceFormRuleID { get; set; }
    }
}