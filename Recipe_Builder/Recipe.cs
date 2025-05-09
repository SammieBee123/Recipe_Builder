﻿using Newtonsoft.Json;
using System;

// Add a comment 


/////////
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

        [JsonProperty("analyzedInstructions")]
        public List<analyzedInstructions> AnalyzedInstructions { get; set; }
        //rename to analyzed instructions
        

    }
}