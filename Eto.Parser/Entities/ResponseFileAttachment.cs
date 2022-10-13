using Newtonsoft.Json;
using System.Collections.Generic;

namespace Eto.Parser.Entities
{
    public class ResponseFileAttachment
    {
        [JsonProperty("Caption")]
        public object Caption { get; set; }

        [JsonProperty("ContentType")]
        public string ContentType { get; set; }

        [JsonProperty("FileContent")]
        public List<int> FileContent { get; set; }

        [JsonProperty("FileName")]
        public string FileName { get; set; }
    }
}