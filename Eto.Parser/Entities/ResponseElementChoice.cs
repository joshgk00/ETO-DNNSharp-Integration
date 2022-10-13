using Newtonsoft.Json;

namespace Eto.Parser.Entities
{
    public class ResponseElementChoice
    {
        [JsonProperty("AuditStaffID")]
        public int AuditStaffID { get; set; }

        [JsonProperty("ResponseChoiceTableID")]
        public int ResponseChoiceTableID { get; set; }

        [JsonProperty("TouchPointElementChoiceID")]
        public int TouchPointElementChoiceID { get; set; }

        [JsonProperty("TouchPointResponseChoiceID")]
        public int TouchPointResponseChoiceID { get; set; }
    }
}