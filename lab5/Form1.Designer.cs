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
            btnUpdate = new Button();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
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
            txtBookBox.Location = new Point(84, 28);
            txtBookBox.Name = "txtBookBox";
            txtBookBox.Size = new Size(263, 27);
            txtBookBox.TabIndex = 1;
            // 
            // btnShowBook
            // 
            btnShowBook.Location = new Point(84, 221);
            btnShowBook.Name = "btnShowBook";
            btnShowBook.Size = new Size(94, 29);
            btnShowBook.TabIndex = 2;
            btnShowBook.Text = "SHOW";
            btnShowBook.UseVisualStyleBackColor = true;
            btnShowBook.Click += btnShowBook_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(84, 266);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(84, 166);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(263, 27);
            txtBookTitle.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(84, 115);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(263, 27);
            txtAuthorName.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(253, 221);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(253, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookTitle);
            Controls.Add(btnUpdate);
            Controls.Add(btnShowBook);
            Controls.Add(txtBookBox);
            Controls.Add(BookBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox BookBox;
        private TextBox txtBookBox;
        private Button btnShowBook;
        private Button btnUpdate;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Button btnDelete;
        private Button btnAdd;
    }
}
