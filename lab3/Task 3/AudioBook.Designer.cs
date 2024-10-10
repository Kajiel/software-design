namespace lab3
{
    partial class AudioBook
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
            ListAudioBook = new ListBox();
            btnInfo = new Button();
            SuspendLayout();
            // 
            // ListAudioBook
            // 
            ListAudioBook.FormattingEnabled = true;
            ListAudioBook.Location = new Point(98, 63);
            ListAudioBook.Name = "ListAudioBook";
            ListAudioBook.Size = new Size(598, 284);
            ListAudioBook.TabIndex = 0;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(98, 366);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(94, 29);
            btnInfo.TabIndex = 1;
            btnInfo.Text = "Show Info";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += this.btnInfo_Click;
            // 
            // AudioBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInfo);
            Controls.Add(ListAudioBook);
            Name = "AudioBook";
            Text = "AudioBook";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListAudioBook;
        private Button btnInfo;
    }
}