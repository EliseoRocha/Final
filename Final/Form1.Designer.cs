namespace Final
{
    partial class MainForm
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
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.RegisterBookButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(56, 61);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(227, 21);
            this.CustomerComboBox.TabIndex = 0;
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(56, 131);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(227, 21);
            this.BookComboBox.TabIndex = 1;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(341, 61);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(133, 48);
            this.AddCustomerButton.TabIndex = 3;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(341, 131);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(133, 44);
            this.AddBookButton.TabIndex = 4;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // RegisterBookButton
            // 
            this.RegisterBookButton.Location = new System.Drawing.Point(103, 269);
            this.RegisterBookButton.Name = "RegisterBookButton";
            this.RegisterBookButton.Size = new System.Drawing.Size(133, 45);
            this.RegisterBookButton.TabIndex = 5;
            this.RegisterBookButton.Text = "Register Book";
            this.RegisterBookButton.UseVisualStyleBackColor = true;
            this.RegisterBookButton.Click += new System.EventHandler(this.RegisterBookButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(341, 269);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(133, 45);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RegisterBookButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.CustomerComboBox);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button RegisterBookButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private new System.Windows.Forms.Button CancelButton;
    }
}

