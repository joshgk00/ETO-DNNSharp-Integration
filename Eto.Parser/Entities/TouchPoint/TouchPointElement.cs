using Newtonsoft.Json;
using System.Collections.Generic;

namespace Eto.Parser.Entities.TouchPoint
{
    public class TouchPointElement
    {
        [JsonProperty("AddressField")]
        public AddressField AddressField { get; set; }

        [JsonProperty("AllowPrePopulate")]
        public bool AllowPrePopulate { get; set; }

        [JsonProperty("AuditStaffID")]
        public int AuditStaffID { get; set; }

        [JsonProperty("CheckIn")]
        public object CheckIn { get; set; }

        [JsonProperty("DateOfNextContact")]
        public object DateOfNextContact { get; set; }

        [JsonProperty("DateWithInProgEnrollment")]
        public bool DateWithInProgEnrollment { get; set; }

        [JsonProperty("DisplayOrder")]
        public object DisplayOrder { get; set; }

        [JsonProperty("ElectronicSignature")]
        public object ElectronicSignature { get; set; }

        [JsonProperty("ElementAttributes")]
        public List<ElementAttribute> ElementAttributes { get; set; }

        [JsonProperty("ElementID")]
        public int ElementID { get; set; }

        [JsonProperty("ElementType")]
        public int ElementType { get; set; }

        [JsonProperty("ErrorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("GridOrTable")]
        public object GridOrTable { get; set; }

        [JsonProperty("IsAllowEditResultForCalculation")]
        public bool IsAllowEditResultForCalculation { get; set; }

        [JsonProperty("IsCommonForGroup")]
        public bool IsCommonForGroup { get; set; }

        [JsonProperty("IsDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("IsRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("IsRequiredForCalculation")]
        public bool IsRequiredForCalculation { get; set; }

        [JsonProperty("IsResultElementForCalculation")]
        public bool IsResultElementForCalculation { get; set; }

        [JsonProperty("IsTouchPointRuleActionToDisable")]
        public bool IsTouchPointRuleActionToDisable { get; set; }

        [JsonProperty("IsTouchPointRuleConditionRequired")]
        public bool IsTouchPointRuleConditionRequired { get; set; }

        [JsonProperty("MainTouchPointElementID")]
        public object MainTouchPointElementID { get; set; }

        [JsonProperty("MultipleChoice")]
        public MultipleChoice MultipleChoice { get; set; }

        [JsonProperty("NumberFutureDays")]
        public object NumberFutureDays { get; set; }

        [JsonProperty("NumberPastDays")]
        public object NumberPastDays { get; set; }

        [JsonProperty("RequireAnAnswerToThisQuestionText")]
        public string RequireAnAnswerToThisQuestionText { get; set; }

        [JsonProperty("RestrictFutureDates")]
        public bool RestrictFutureDates { get; set; }

        [JsonProperty("RestrictPastDates")]
        public bool RestrictPastDates { get; set; }

        [JsonProperty("SequenceOrder")]
        public int SequenceOrder { get; set; }

        [JsonProperty("StartAndEndTime")]
        public object StartAndEndTime { get; set; }

        [JsonProperty("Stimulus")]
        public string Stimulus { get; set; }

        [JsonProperty("StimulusHTML")]
        public string StimulusHTML { get; set; }

        [JsonProperty("TouchPointID")]
        public int TouchPointID { get; set; }

        [JsonProperty("UsePseudonym")]
        public string UsePseudonym { get; set; }
    }
}