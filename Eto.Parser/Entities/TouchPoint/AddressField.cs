using Newtonsoft.Json;

namespace Eto.Parser.Entities.TouchPoint
{
    public class AddressField
    {
        [JsonProperty("AddressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("AddressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Company")]
        public string Company { get; set; }

        [JsonProperty("County")]
        public object County { get; set; }

        [JsonProperty("Name")]
        public object Name { get; set; }

        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }
    }
}