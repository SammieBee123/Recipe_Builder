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
            tabPage1 = new TabPage();
            pictureBox2 = new PictureBox();
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
            tabPage2 = new TabPage();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Search.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox2);
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
            tabPage1.Size = new Size(1291, 532);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.vecteezy_question_mark_icon_51454748;
            pictureBox2.Location = new Point(1209, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(341, 22);
            label2.Name = "label2";
            label2.Size = new Size(526, 54);
            label2.TabIndex = 9;
            label2.Text = "Welcome to Recipe Finder!";
            // 
            // recipesListBox
            // 
            recipesListBox.FormattingEnabled = true;
            recipesListBox.HorizontalScrollbar = true;
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
            keywordTextBox.Location = new Point(450, 147);
            keywordTextBox.Margin = new Padding(1, 2, 1, 2);
            keywordTextBox.Name = "keywordTextBox";
            keywordTextBox.Size = new Size(313, 31);
            keywordTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(81, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 217);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Diet Restriction";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 178);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(116, 29);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Ketogenic";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 143);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(125, 29);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Pescetarian";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 108);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(127, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Gluten Free";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 73);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Vegetarian";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Vegan";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // getButton
            // 
            getButton.Location = new Point(771, 143);
            getButton.Margin = new Padding(1, 2, 1, 2);
            getButton.Name = "getButton";
            getButton.Size = new Size(111, 33);
            getButton.TabIndex = 1;
            getButton.Text = "Results";
            getButton.UseVisualStyleBackColor = true;
            getButton.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(957, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(636, 435);
            exitButton.Margin = new Padding(1, 2, 1, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(154, 53);
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
            Search.Size = new Size(1299, 570);
            Search.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1291, 532);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Recipe";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(45, 152);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox2.Size = new Size(286, 355);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlLightLight;
            richTextBox1.Location = new Point(376, 152);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(886, 355);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
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
            label5.Location = new Point(45, 115);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 3;
            label5.Text = "Ingredients:";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 570);
            Controls.Add(Search);
            Margin = new Padding(1, 2, 1, 2);
            Name = "Form1";
            Text = "Recipe Builder";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Search.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private PictureBox pictureBox2;
        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private RichTextBox richTextBox2;
    }
}
