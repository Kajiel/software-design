namespace lab5
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
            BookBox = new ListBox();
            txtBookBox = new TextBox();
            btnShowBook = new Button();
            button1 = new Button();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            btnSearchAuthor = new Button();
            SuspendLayout();
            // 
            // BookBox
            // 
            BookBox.Font = new Font("Mongolian Baiti", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBox.ForeColor = SystemColors.WindowText;
            BookBox.FormattingEnabled = true;
            BookBox.ItemHeight = 16;
            BookBox.Location = new Point(434, 28);
            BookBox.Name = "BookBox";
            BookBox.Size = new Size(299, 356);
            BookBox.TabIndex = 0;
            // 
            // txtBookBox
            // 
            txtBookBox.Location = new Point(84, 159);
            txtBookBox.Name = "txtBookBox";
            txtBookBox.Size = new Size(263, 27);
            txtBookBox.TabIndex = 1;
            // 
            // btnShowBook
            // 
            btnShowBook.Location = new Point(84, 355);
            btnShowBook.Name = "btnShowBook";
            btnShowBook.Size = new Size(94, 29);
            btnShowBook.TabIndex = 2;
            btnShowBook.Text = "SHOW";
            btnShowBook.UseVisualStyleBackColor = true;
            btnShowBook.Click += btnShowBook_Click;
            // 
            // button1
            // 
            button1.Location = new Point(253, 355);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(84, 232);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(263, 27);
            txtBookTitle.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(84, 301);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(263, 27);
            txtAuthorName.TabIndex = 6;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Location = new Point(434, 399);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(94, 29);
            btnSearchAuthor.TabIndex = 7;
            btnSearchAuthor.Text = "SEARCH";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchAuthor);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookTitle);
            Controls.Add(button1);
            Controls.Add(btnShowBook);
            Controls.Add(txtBookBox);
            Controls.Add(BookBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox BookBox;
        private TextBox txtBookBox;
        private Button btnShowBook;
        private Button button1;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Button btnSearchAuthor;
    }
}
