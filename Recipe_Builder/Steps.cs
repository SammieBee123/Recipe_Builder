using Newtonsoft.Json;
using System;

namespace Recipe_Builder
{
    [Serializable]
    public class Steps
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }
    }
}