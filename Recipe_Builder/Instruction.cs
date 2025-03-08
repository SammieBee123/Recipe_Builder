using Newtonsoft.Json;
using System;

namespace Recipe_Builder
{
    [Serializable]
    public class Instruction
    {
        [JsonProperty("steps[number]")]
        public int Number { get; set; }

        [JsonProperty("steps[step]")]
        public string step { get; set; }

        [JsonProperty("steps[ingredient[id]]")]
        public string id { get; set; }
    }
}