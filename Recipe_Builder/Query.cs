using Recipe_Builder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

public class SpoonacularService : ISpoonacularService
{
    public async Task<IEnumerable<Recipe>> Get5Recipies(String query, String dietList)
    {
        List<Recipe> recipes = new List<Recipe>();

        var url = $"https://api.spoonacular.com/recipes/complexSearch";
        var parameters = $"?query={query}&addRecipeInstructions=true&apiKey={Consts.SPOONACULAR_API_KEY}&number=10&diet={dietList}&addRecipeInformation=true";

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        HttpResponseMessage response = await client.GetAsync(parameters).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            var recipeList = JsonConvert.DeserializeObject<RecipeList>(jsonString);

            if (recipeList != null)
            {
                recipes.AddRange(recipeList.Recipes);
            }
        }

        return recipes;
    }
    public async Task<IEnumerable<ExtendedIngredients>> GetRecipeDetails(Recipe choice)
    {
        List<ExtendedIngredients> Ingredients = new List<ExtendedIngredients>();

        var url = $"https://api.spoonacular.com/recipes/{choice.Id}/information";
        var parameters = $"?id={choice.Id}&apiKey={Consts.SPOONACULAR_API_KEY}";

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        HttpResponseMessage response = await client.GetAsync(parameters).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            var IngredientsList = JsonConvert.DeserializeObject<IngredientList>(jsonString);
            if (IngredientsList != null)
            {
                Ingredients.AddRange(IngredientsList.ExtendedIngredients);
            }
        }

        return Ingredients;
    }
    public async Task<Recipe> GetInstructions(Recipe choice)
    {
        var url = $"https://api.spoonacular.com/recipes/{choice.Id}/analyzedInstructions";
        var parameters = $"?id={choice.Id}&apiKey={Consts.SPOONACULAR_API_KEY}";

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        HttpResponseMessage response = await client.GetAsync(parameters).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            var recipe = JsonConvert.DeserializeObject<Recipe>(jsonString);
            return recipe;
        }

        return choice;
    }
}
