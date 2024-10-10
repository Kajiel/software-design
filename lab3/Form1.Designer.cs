namespace lab3
{
	partial class TextBook
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
            components = new System.ComponentModel.Container();
            btnInfo = new Button();
            imageList1 = new ImageList(components);
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(48, 322);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(94, 29);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "Show Info";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(48, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(711, 264);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(186, 322);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // TextBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(btnInfo);
            Name = "TextBook";
            Text = "Grabe&Read";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInfo;
        private ImageList imageList1;
        private ListBox listBox1;
        private Button button1;
    }
}
