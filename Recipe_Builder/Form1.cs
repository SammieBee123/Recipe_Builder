using System.Windows.Forms.VisualStyles;

namespace Recipe_Builder
{
    public partial class Form1 : Form
    {
        private SpoonacularService setQuery;
        public Form1(SpoonacularService query)
        {
            setQuery = query;
            InitializeComponent();

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            recipesListBox.Items.Clear();
            List<Recipe> returnedRecipes = new List<Recipe>();
            // SpoonacularService list = new SpoonacularService();
            // string recipes = list.Get5Recipies(keywordTextBox.Text);

            //recipesListBox.Items.Add(setQuery.Get5Recipies(keywordTextBox.Text));
            string keyword = keywordTextBox.Text;
            if (keyword != null)
            {
                IEnumerable<Recipe> recipes = await setQuery.Get5Recipies(keyword);
                returnedRecipes = recipes.ToList();
                foreach (var recipe in returnedRecipes)
                    {
                    recipesListBox.Items.Add(recipe.Title);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
