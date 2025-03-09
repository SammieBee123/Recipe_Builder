using Newtonsoft.Json;
using System;

namespace Recipe_Builder
{
    [Serializable]
    public class Ingredient
    {

        [JsonProperty("extendedIngredients[original]")]
        public string Original { get; set; }

    }
}