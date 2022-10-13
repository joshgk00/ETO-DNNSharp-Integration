using Newtonsoft.Json;
using System.Collections.Generic;

namespace Eto.Parser.Entities.Demographics
{
    public class AttachmentInfo
    {
    }

    public class DemographicItem
    {
        [JsonProperty("AttachmentInfo")]
        public AttachmentInfo AttachmentInfo { get; set; }

        [JsonProperty("CDID")]
        public int CDID { get; set; }

        [JsonProperty("CharacteristicType")]
        public int CharacteristicType { get; set; }

        [JsonProperty("DTVDisabled")]
        public object DTVDisabled { get; set; }

        [JsonProperty("DefinedTextValues")]
        public List<DefinedTextValue> DefinedTextValues { get; set; }

        [JsonProperty("DemographicName")]
        public string DemographicName { get; set; }

        [JsonProperty("DemographicTextValue")]
        public object DemographicTextValue { get; set; }

        [JsonProperty("Disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("IsRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("ProgramID")]
        public object ProgramID { get; set; }

        [JsonProperty("SiteID")]
        public int? SiteID { get; set; }

        [JsonProperty("StandardDemographicID")]
        public int? StandardDemographicID { get; set; }

        [JsonProperty("ViewOnly")]
        public bool ViewOnly { get; set; }

        [JsonProperty("ViewOnlyAfterInitialSave")]
        public bool ViewOnlyAfterInitialSave { get; set; }
    }
}