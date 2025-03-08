using Newtonsoft.Json;
using Recipe_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Builder
{
    [Serializable]
    public class IngredientList
    {
        [JsonProperty("results")]
        public IEnumerable<Ingredient> Ingredient { get; set; }
    }
}