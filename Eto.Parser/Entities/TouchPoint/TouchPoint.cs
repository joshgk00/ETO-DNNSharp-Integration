using Newtonsoft.Json;
using System.Collections.Generic;

namespace Eto.Parser.Entities.TouchPoint
{
    public class TouchPoint
    {
        [JsonProperty("AllowClientSelfTracking")]
        public bool AllowClientSelfTracking { get; set; }

        [JsonProperty("AllowIdentifierAuto")]
        public bool AllowIdentifierAuto { get; set; }

        [JsonProperty("AllowPrePopulate")]
        public bool AllowPrePopulate { get; set; }

        [JsonProperty("AllowPrepopulateFromSite")]
        public bool AllowPrepopulateFromSite { get; set; }

        [JsonProperty("AllowSaveDraft")]
        public bool AllowSaveDraft { get; set; }

        [JsonProperty("AllowSaveProgress")]
        public bool AllowSaveProgress { get; set; }

        [JsonProperty("AuditStaffID")]
        public int AuditStaffID { get; set; }

        [JsonProperty("DataByAnotherStaff")]
        public bool DataByAnotherStaff { get; set; }

        [JsonProperty("DateWithInProgEnrollment")]
        public bool DateWithInProgEnrollment { get; set; }

        [JsonProperty("ETOSyncActivity")]
        public bool ETOSyncActivity { get; set; }

        [JsonProperty("ErrorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("FormCalculations")]
        public List<object> FormCalculations { get; set; }

        [JsonProperty("FormRules")]
        public List<FormRule> FormRules { get; set; }

        [JsonProperty("IsDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("LockRespForUpdatingAfterXDay")]
        public object LockRespForUpdatingAfterXDay { get; set; }

        [JsonProperty("NumberFutureDays")]
        public object NumberFutureDays { get; set; }

        [JsonProperty("NumberPastDays")]
        public object NumberPastDays { get; set; }

        [JsonProperty("ParentTouchPointID")]
        public int ParentTouchPointID { get; set; }

        [JsonProperty("QuestionNumberingEnabled")]
        public bool QuestionNumberingEnabled { get; set; }

        [JsonProperty("RecordSimilarEffort")]
        public bool RecordSimilarEffort { get; set; }

        [JsonProperty("RestrictFutureDates")]
        public bool RestrictFutureDates { get; set; }

        [JsonProperty("RestrictPastDates")]
        public bool RestrictPastDates { get; set; }

        [JsonProperty("SectionHeaderQuickLink")]
        public bool SectionHeaderQuickLink { get; set; }

        [JsonProperty("TouchPointCompletionRestriction")]
        public int TouchPointCompletionRestriction { get; set; }

        [JsonProperty("TouchPointCompletionRestrictionValue")]
        public int TouchPointCompletionRestrictionValue { get; set; }

        [JsonProperty("TouchPointElement")]
        public List<TouchPointElement> TouchPointElement { get; set; }

        [JsonProperty("TouchPointID")]
        public int TouchPointID { get; set; }

        [JsonProperty("TouchPointIdentifier")]
        public int TouchPointIdentifier { get; set; }

        [JsonProperty("TouchPointIdentifierRequired")]
        public bool TouchPointIdentifierRequired { get; set; }

        [JsonProperty("TouchPointName")]
        public string TouchPointName { get; set; }

        [JsonProperty("TouchPointTag")]
        public string TouchPointTag { get; set; }
    }
}