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
            image = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // image
            // 
            image.Location = new Point(646, 307);
            image.Name = "image";
            image.Size = new Size(112, 34);
            image.TabIndex = 7;
            image.Text = "Show Image";
            image.UseVisualStyleBackColor = true;
            image.Click += image_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 398);
            Controls.Add(image);
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
        private Button image;
    }
}
