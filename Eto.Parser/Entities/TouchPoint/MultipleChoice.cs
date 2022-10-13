using Newtonsoft.Json;
using System.Collections.Generic;

namespace Eto.Parser.Entities.TouchPoint
{
    public class MultipleChoice
    {
        [JsonProperty("ChoiceValues")]
        public List<ChoiceValue> ChoiceValues { get; set; }
    }
}