using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Builder
{ 
    interface ISpoonacularService
    {
        Task<IEnumerable<Recipe>> Get5Recipies(String query, String dietList);
    }
}