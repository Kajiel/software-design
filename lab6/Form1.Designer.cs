namespace lab6
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
            btnFetchBooks = new Button();
            btnAddBooks = new Button();
            btnUpdateBooks = new Button();
            btnDeleteBooks = new Button();
            btnSearchBooks = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            listBoxBooks = new ListBox();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            progressBar1 = new ProgressBar();
            txtBookID = new TextBox();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(114, 277);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(94, 29);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "FETCH";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // btnAddBooks
            // 
            btnAddBooks.Location = new Point(114, 232);
            btnAddBooks.Name = "btnAddBooks";
            btnAddBooks.Size = new Size(94, 29);
            btnAddBooks.TabIndex = 1;
            btnAddBooks.Text = "ADD";
            btnAddBooks.UseVisualStyleBackColor = true;
            btnAddBooks.Click += btnAddBooks_Click;
            // 
            // btnUpdateBooks
            // 
            btnUpdateBooks.Location = new Point(261, 277);
            btnUpdateBooks.Name = "btnUpdateBooks";
            btnUpdateBooks.Size = new Size(94, 29);
            btnUpdateBooks.TabIndex = 2;
            btnUpdateBooks.Text = "UPDATE";
            btnUpdateBooks.UseVisualStyleBackColor = true;
            btnUpdateBooks.Click += btnUpdateBooks_Click;
            // 
            // btnDeleteBooks
            // 
            btnDeleteBooks.Location = new Point(261, 232);
            btnDeleteBooks.Name = "btnDeleteBooks";
            btnDeleteBooks.Size = new Size(94, 29);
            btnDeleteBooks.TabIndex = 3;
            btnDeleteBooks.Text = "DELETE";
            btnDeleteBooks.UseVisualStyleBackColor = true;
            btnDeleteBooks.Click += btnDeleteBooks_Click;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(114, 24);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(94, 29);
            btnSearchBooks.TabIndex = 4;
            btnSearchBooks.Text = "SEARCH";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(470, 47);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(268, 304);
            listBoxBooks.TabIndex = 5;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(114, 128);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(241, 27);
            txtBookTitle.TabIndex = 6;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(114, 175);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(241, 27);
            txtAuthorName.TabIndex = 7;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(470, 369);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(268, 29);
            progressBar1.TabIndex = 8;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(114, 59);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(241, 27);
            txtBookID.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBookID);
            Controls.Add(progressBar1);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookTitle);
            Controls.Add(listBoxBooks);
            Controls.Add(btnSearchBooks);
            Controls.Add(btnDeleteBooks);
            Controls.Add(btnUpdateBooks);
            Controls.Add(btnAddBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookStore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private Button btnAddBooks;
        private Button btnUpdateBooks;
        private Button btnDeleteBooks;
        private Button btnSearchBooks;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ListBox listBoxBooks;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private ProgressBar progressBar1;
        private TextBox txtBookID;
    }
}
