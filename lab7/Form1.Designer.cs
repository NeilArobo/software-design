namespace lab7
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
            btnBackPage = new Button();
            lblPageNumber = new Label();
            btnNextPage = new Button();
            listBoxBooks = new ListBox();
            SuspendLayout();
            // 
            // btnBackPage
            // 
            btnBackPage.Location = new Point(220, 409);
            btnBackPage.Name = "btnBackPage";
            btnBackPage.Size = new Size(94, 29);
            btnBackPage.TabIndex = 0;
            btnBackPage.Text = "Back";
            btnBackPage.UseVisualStyleBackColor = true;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(379, 413);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(41, 20);
            lblPageNumber.TabIndex = 1;
            lblPageNumber.Text = "Page";
            lblPageNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(487, 409);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(12, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(776, 384);
            listBoxBooks.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxBooks);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
            Controls.Add(btnBackPage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackPage;
        private Label lblPageNumber;
        private Button btnNextPage;
        private ListBox listBoxBooks;
    }
}
