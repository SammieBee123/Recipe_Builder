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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
