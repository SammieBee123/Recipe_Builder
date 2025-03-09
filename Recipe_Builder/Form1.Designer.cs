namespace Recipe_Builder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            ingredientsLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            tabPage1 = new TabPage();
            label2 = new Label();
            recipesListBox = new ListBox();
            getRecipe = new Button();
            keywordTextBox = new TextBox();
            groupBox1 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            getButton = new Button();
            pictureBox1 = new PictureBox();
            exitButton = new Button();
            label1 = new Label();
            Search = new TabControl();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Search.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(ingredientsLabel);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1319, 610);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Recipe";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 115);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 4;
            label6.Text = "Instructions:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label5.Location = new Point(61, 115);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 3;
            label5.Text = "Ingredients:";
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.BorderStyle = BorderStyle.FixedSingle;
            ingredientsLabel.Location = new Point(61, 151);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(2, 27);
            ingredientsLabel.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(279, 27);
            label4.Name = "label4";
            label4.Size = new Size(0, 54);
            label4.TabIndex = 1;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(366, 151);
            label3.Name = "label3";
            label3.Size = new Size(896, 356);
            label3.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(recipesListBox);
            tabPage1.Controls.Add(getRecipe);
            tabPage1.Controls.Add(keywordTextBox);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(getButton);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(exitButton);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1319, 610);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(341, 21);
            label2.Name = "label2";
            label2.Size = new Size(526, 54);
            label2.TabIndex = 9;
            label2.Text = "Welcome to Recipe Finder!";
            // 
            // recipesListBox
            // 
            recipesListBox.FormattingEnabled = true;
            recipesListBox.ItemHeight = 25;
            recipesListBox.Location = new Point(350, 198);
            recipesListBox.Name = "recipesListBox";
            recipesListBox.Size = new Size(528, 204);
            recipesListBox.TabIndex = 4;
            recipesListBox.SelectedIndexChanged += recipesListBox_SelectedIndexChanged;
            // 
            // getRecipe
            // 
            getRecipe.Location = new Point(440, 435);
            getRecipe.Name = "getRecipe";
            getRecipe.Size = new Size(133, 53);
            getRecipe.TabIndex = 8;
            getRecipe.Text = "Get Recipe";
            getRecipe.UseVisualStyleBackColor = true;
            getRecipe.Click += getRecipe_Click;
            // 
            // keywordTextBox
            // 
            keywordTextBox.Location = new Point(450, 146);
            keywordTextBox.Margin = new Padding(2);
            keywordTextBox.Name = "keywordTextBox";
            keywordTextBox.Size = new Size(312, 31);
            keywordTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(82, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 217);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Diet Restriction";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 179);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(116, 29);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Ketogenic";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 144);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(125, 29);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Pescetarian";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 109);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(127, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Gluten Free";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 74);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Vegetarian";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Vegan";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // getButton
            // 
            getButton.Location = new Point(772, 143);
            getButton.Margin = new Padding(2);
            getButton.Name = "getButton";
            getButton.Size = new Size(111, 34);
            getButton.TabIndex = 1;
            getButton.Text = "Results";
            getButton.UseVisualStyleBackColor = true;
            getButton.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(957, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 234);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(636, 435);
            exitButton.Margin = new Padding(2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(155, 53);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 148);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 3;
            label1.Text = "Search for:";
            // 
            // Search
            // 
            Search.Controls.Add(tabPage1);
            Search.Controls.Add(tabPage2);
            Search.Location = new Point(0, 2);
            Search.Name = "Search";
            Search.SelectedIndex = 0;
            Search.Size = new Size(1327, 648);
            Search.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 570);
            Controls.Add(Search);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Recipe Builder";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Search.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private Label label3;
        private TabPage tabPage1;
        private Label label2;
        private ListBox recipesListBox;
        private Button getRecipe;
        private TextBox keywordTextBox;
        private GroupBox groupBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button getButton;
        private PictureBox pictureBox1;
        private Button exitButton;
        private Label label1;
        private TabControl Search;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label ingredientsLabel;
    }
}
