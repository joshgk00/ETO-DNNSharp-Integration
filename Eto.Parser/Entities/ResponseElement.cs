using Newtonsoft.Json;
using System.Collections.Generic;

namespace Eto.Parser.Entities
{
    public class ResponseElement
    {
        [JsonProperty("AttachmentDetailType")]
        public int AttachmentDetailType { get; set; }

        [JsonProperty("DateOfNextContactDetailType")]
        public int DateOfNextContactDetailType { get; set; }

        [JsonProperty("ElementID")]
        public int ElementID { get; set; }

        [JsonProperty("ElementType")]
        public int ElementType { get; set; }

        [JsonProperty("ResponseAddressField")]
        public ResponseAddressField ResponseAddressField { get; set; }

        [JsonProperty("ResponseCheckInField")]
        public object ResponseCheckInField { get; set; }

        [JsonProperty("ResponseDateOfNextContact")]
        public object ResponseDateOfNextContact { get; set; }

        [JsonProperty("ResponseElementChoices")]
        public List<ResponseElementChoice> ResponseElementChoices { get; set; }

        [JsonProperty("ResponseFileAttachment")]
        public ResponseFileAttachment ResponseFileAttachment { get; set; }

        [JsonProperty("ResponseFileAttachments")]
        public List<ResponseFileAttachment> ResponseFileAttachments { get; set; }

        [JsonProperty("ResponseStartAndEndTime")]
        public object ResponseStartAndEndTime { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}