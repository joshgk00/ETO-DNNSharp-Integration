using Newtonsoft.Json;

namespace Eto.Parser.Entities
{
    public class CustomDemoData
    {
        [JsonProperty("ETOBaseException")]
        public object ETOBaseException { get; set; }

        [JsonProperty("Name")]
        public object Name { get; set; }

        [JsonProperty("Required")]
        public bool Required { get; set; }

        [JsonProperty("Sequence")]
        public int Sequence { get; set; }

        [JsonProperty("Session")]
        public object Session { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("ByteSize")]
        public int ByteSize { get; set; }

        [JsonProperty("CDID")]
        public int CDID { get; set; }

        [JsonProperty("CharacteristicType")]
        public int CharacteristicType { get; set; }

        [JsonProperty("CustomSettings")]
        public object CustomSettings { get; set; }

        [JsonProperty("DTV")]
        public object DTV { get; set; }

        [JsonProperty("DTVDisabled")]
        public object DTVDisabled { get; set; }

        [JsonProperty("Disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("EntitySubTypeID")]
        public object EntitySubTypeID { get; set; }

        [JsonProperty("EntityTypeID")]
        public object EntityTypeID { get; set; }

        [JsonProperty("FileAttachment")]
        public object FileAttachment { get; set; }

        [JsonProperty("FileAttachmentData")]
        public object FileAttachmentData { get; set; }

        [JsonProperty("FromSelfServicePortal")]
        public bool FromSelfServicePortal { get; set; }

        [JsonProperty("IncludeInFamilyCopy")]
        public object IncludeInFamilyCopy { get; set; }

        [JsonProperty("IsDirty")]
        public bool IsDirty { get; set; }

        [JsonProperty("ProgramID")]
        public object ProgramID { get; set; }

        [JsonProperty("ShortDescription")]
        public object ShortDescription { get; set; }

        [JsonProperty("SiteID")]
        public object SiteID { get; set; }

        [JsonProperty("StandardDemographicID")]
        public object StandardDemographicID { get; set; }

        [JsonProperty("UIDisabled")]
        public bool UIDisabled { get; set; }

        [JsonProperty("UIDisabledAfterInitialSave")]
        public bool UIDisabledAfterInitialSave { get; set; }
    }
}