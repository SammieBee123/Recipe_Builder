using System.Windows.Forms.VisualStyles;

namespace Recipe_Builder
{
    public partial class Form1 : Form
    {
        int selectedIndex = 0;
        List<Recipe> returnedRecipes = new List<Recipe>();
        private SpoonacularService setQuery;
        public Form1(SpoonacularService query)
        {
            setQuery = query;
            InitializeComponent();

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            recipesListBox.Items.Clear();
            List<string> dietList = new List<string>();

            if (checkBox1.Checked)
            { dietList.Add("vegan"); }

            if (checkBox2.Checked)
            { dietList.Add("vegetarian"); }

            if (checkBox3.Checked)
            { dietList.Add("glutenfree"); }

            if (checkBox4.Checked)
            { dietList.Add("pescetarian"); }

            if (checkBox5.Checked)
            { dietList.Add("ketogenic"); }

            string restriction = "";

            int n = dietList.Count();

            foreach (string diet in dietList)
            {
                restriction += diet;
                if (diet != dietList[n - 1])
                { restriction += ","; }

            }
            ////
            //MessageBox.Show(restriction);
            // SpoonacularService list = new SpoonacularService();
            // string recipes = list.Get5Recipies(keywordTextBox.Text);
            //ch

            //recipesListBox.Items.Add(setQuery.Get5Recipies(keywordTextBox.Text));
            string keyword = keywordTextBox.Text;
            if (keyword != null)
            {
                IEnumerable<Recipe> recipes = await setQuery.Get5Recipies(keyword, restriction);
                returnedRecipes = recipes.ToList();
                foreach (var recipe in returnedRecipes)
                {
                    recipesListBox.Items.Add(recipe.Title);
                    //pictureBox1.Visible(recipe.Image);
                }
            }
            else
            {
                MessageBox.Show("Invalid Keyword");
            }
            //MessageBox.Show(returnedRecipes.Count.ToString());
            //pictureBox1.Visible = false;

            /*if (recipesListBox.SelectedIndex >= 0)
            {
                int index = recipesListBox.SelectedIndex;

                if (index < returnedRecipes.Count)
                {
                    string imageUrl = returnedRecipes[index].Image;

                    try
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.Load(imageUrl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }*/

            /* switch (recipesListBox.SelectedIndex)
             {
                 case 0:
                     pictureBox1.Visible = true;
                     pictureBox1.Load(returnedRecipes[recipesListBox.SelectedIndex].Image);
                     break;

                 case 1:
                     pictureBox1.Visible = true;
                     pictureBox1.Load();
                     break;

                 case 2:
                     pictureBox1.Visible = true;
                     pictureBox1.Load();
                     break;

                 case 3:
                     pictureBox1.Visible = true;
                     pictureBox1.Load();
                     break;

                 case 4:
                     pictureBox1.Visible = true;
                     pictureBox1.Load();
                     break;

             }*/

            //if(pic == -1)
            //{
            //    int i = recipesListBox.SelectedIndex;
            //    // if (recipesListBox.SelectedIndex == i)
            //    if (i >= 0 && i < returnedRecipes.Count)
            //    {
            //        pictureBox1.Visible = true;
            //        pictureBox1.Load(returnedRecipes[i].Image);
            //    }
            //}



            //}
            /*  //foreach (var recipe in returnedRecipes)
              {
                  //if (recipesListBox.SelectedIndex == i)
                  //{
                      pictureBox1.Visible = true;
                      pictureBox1.Load(recipe.Image);
                  //}
                  //pictureBox1.Visible(recipe.Image);
              }*/
            //for (int i = 0; i < returnedRecipes.Count; i++)
            //{


            //while (recipesListBox.SelectedIndex != -1)
            //{ 
            //int index = recipesListBox.SelectedIndex;
            //  pictureBox1.Visible = true;
            //  pictureBox1.Load(returnedRecipes[index].Image);

            //}
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void recipesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = recipesListBox.SelectedIndex;
            // if (recipesListBox.SelectedIndex == i)
            if (selectedIndex >= 0 && selectedIndex < returnedRecipes.Count)
            {
               // pictureBox1.Visible = true;
                try
                {
                    pictureBox1.Load(returnedRecipes[selectedIndex].Image);
                }
                catch
                {
                    pictureBox1.Visible = true;
                }
            }
        }

        private async void getRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                Search.SelectedTab = tabPage2;

                label4.Text = returnedRecipes[selectedIndex].Title;
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                int stepNumber = 1;
                //MessageBox.Show(returnedRecipes[selectedIndex ].AnalyzedInstructions);
                IEnumerable<ExtendedIngredients> ExtendedIngredients = await setQuery.GetRecipeDetails(returnedRecipes[selectedIndex]);
                foreach (var Original in ExtendedIngredients.Select(x => x.Original))
                {
                    richTextBox2.Text += Original.ToString();
                    richTextBox2.Text += "\n";
                    //MessageBox.Show(Original.ToString());
                }
                foreach (var Steps in returnedRecipes[selectedIndex].AnalyzedInstructions.Select(x => x.Steps))
                {
                    foreach (var Step in Steps.Select(x => x.Step))
                    {
                        richTextBox1.Text += stepNumber.ToString() + ". ";
                        //MessageBox.Show(Step.ToString());
                        richTextBox1.Text += Step.ToString();
                        richTextBox1.Text += "\n \n";
                        stepNumber++;

                    }

                }
            }
            catch
            {
                MessageBox.Show("Please search for recipes before getting the recipe.");
                Search.SelectedTab = tabPage1;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a cuisine type, ingredient, dish, etc., into the search bar and click \"Results\". Then" +
                " select one of the recipe options and click \"Get Recipe\".");

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}