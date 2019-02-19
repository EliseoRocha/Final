namespace Final
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(105, 39);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(100, 20);
            this.ISBNTextBox.TabIndex = 3;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(104, 65);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 4;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(104, 97);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 5;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(104, 136);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(100, 23);
            this.AddBookButton.TabIndex = 6;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 252);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBookForm";
            this.Text = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button AddBookButton;
    }
}