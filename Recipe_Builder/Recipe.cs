using Newtonsoft.Json;
using System;

namespace Recipe_Builder
{ 
    [Serializable]
    public class Recipe
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }
        [JsonProperty("instructions[steps]")]
        public int Number { get; set; }

        [JsonProperty("instructions[steps]")]
        public InstructionList step { get; set; }

        

    }
}