using Newtonsoft.Json;
using System;

namespace Recipe_Builder
{
    [Serializable]
    public class Instruction
    {
        [JsonProperty("steps[number]")]
        public int Number { get; set; }

        [JsonProperty("steps")]
        public string step { get; set; }
    }
}