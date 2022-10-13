using Newtonsoft.Json;

namespace Eto.Parser.Entities
{
    public class ResponseAddressField
    {
        [JsonProperty("AddressLine1")]
        public object AddressLine1 { get; set; }

        [JsonProperty("AddressLine2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("City")]
        public object City { get; set; }

        [JsonProperty("Company")]
        public object Company { get; set; }

        [JsonProperty("Country")]
        public object Country { get; set; }

        [JsonProperty("County")]
        public object County { get; set; }

        [JsonProperty("Name")]
        public object Name { get; set; }

        [JsonProperty("PostalCode")]
        public object PostalCode { get; set; }

        [JsonProperty("State")]
        public object State { get; set; }
    }
}