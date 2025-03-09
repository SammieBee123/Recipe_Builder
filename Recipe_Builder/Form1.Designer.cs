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
            keywordTextBox = new TextBox();
            getButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            recipesListBox = new ListBox();
            displayLabel = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            getRecipe = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // keywordTextBox
            // 
            keywordTextBox.Location = new Point(228, 31);
            keywordTextBox.Margin = new Padding(2);
            keywordTextBox.Name = "keywordTextBox";
            keywordTextBox.Size = new Size(312, 31);
            keywordTextBox.TabIndex = 0;
            // 
            // getButton
            // 
            getButton.Location = new Point(143, 320);
            getButton.Margin = new Padding(2);
            getButton.Name = "getButton";
            getButton.Size = new Size(152, 51);
            getButton.TabIndex = 1;
            getButton.Text = "Get Recipes";
            getButton.UseVisualStyleBackColor = true;
            getButton.Click += button1_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(388, 320);
            exitButton.Margin = new Padding(2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(152, 51);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 34);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 3;
            label1.Text = "Enter keywords:";
            // 
            // recipesListBox
            // 
            recipesListBox.FormattingEnabled = true;
            recipesListBox.ItemHeight = 25;
            recipesListBox.Location = new Point(62, 84);
            recipesListBox.Name = "recipesListBox";
            recipesListBox.Size = new Size(528, 204);
            recipesListBox.TabIndex = 4;
            recipesListBox.SelectedIndexChanged += recipesListBox_SelectedIndexChanged;
            // 
            // displayLabel
            // 
            displayLabel.BorderStyle = BorderStyle.FixedSingle;
            displayLabel.Location = new Point(699, 311);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(258, 69);
            displayLabel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(699, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 234);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(997, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 229);
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
            // getRecipe
            // 
            getRecipe.Location = new Point(1081, 320);
            getRecipe.Name = "getRecipe";
            getRecipe.Size = new Size(112, 34);
            getRecipe.TabIndex = 8;
            getRecipe.Text = "Get Recipe";
            getRecipe.UseVisualStyleBackColor = true;
            getRecipe.Click += getRecipe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 398);
            Controls.Add(getRecipe);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(displayLabel);
            Controls.Add(recipesListBox);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(getButton);
            Controls.Add(keywordTextBox);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Recipe Builder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox keywordTextBox;
        private Button getButton;
        private Button exitButton;
        private Label label1;
        private ListBox recipesListBox;
        private Label displayLabel;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button getRecipe;
    }
}
