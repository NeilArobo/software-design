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
            btnPreviousPage = new Button();
            lblPageNumber = new Label();
            btnNextPage = new Button();
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            label1 = new Label();
            txtboxBookTitle = new TextBox();
            txtboxAuthorName = new TextBox();
            label2 = new Label();
            btnExportBooks = new Button();
            btnSearchBooks = new Button();
            btnImportBooks = new Button();
            SuspendLayout();
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(359, 409);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 0;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(470, 413);
            lblPageNumber.MinimumSize = new Size(150, 20);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(150, 20);
            lblPageNumber.TabIndex = 1;
            lblPageNumber.Text = "Page";
            lblPageNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(637, 409);
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
            listBoxBooks.Location = new Point(314, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(474, 384);
            listBoxBooks.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(47, 173);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 54);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 5;
            label1.Text = "Book Title:";
            // 
            // txtboxBookTitle
            // 
            txtboxBookTitle.Location = new Point(32, 48);
            txtboxBookTitle.Name = "txtboxBookTitle";
            txtboxBookTitle.Size = new Size(256, 27);
            txtboxBookTitle.TabIndex = 6;
            // 
            // txtboxAuthorName
            // 
            txtboxAuthorName.Location = new Point(32, 119);
            txtboxAuthorName.Name = "txtboxAuthorName";
            txtboxAuthorName.Size = new Size(256, 27);
            txtboxAuthorName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 96);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 8;
            label2.Text = "Author Name:";
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(172, 173);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(94, 54);
            btnExportBooks.TabIndex = 9;
            btnExportBooks.Text = "Export Books";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(47, 242);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(94, 54);
            btnSearchBooks.TabIndex = 10;
            btnSearchBooks.Text = "Search Books";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // btnImportBooks
            // 
            btnImportBooks.Location = new Point(172, 242);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(94, 54);
            btnImportBooks.TabIndex = 11;
            btnImportBooks.Text = "Import Books";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnImportBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImportBooks);
            Controls.Add(btnSearchBooks);
            Controls.Add(btnExportBooks);
            Controls.Add(label2);
            Controls.Add(txtboxAuthorName);
            Controls.Add(txtboxBookTitle);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
            Controls.Add(btnPreviousPage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPreviousPage;
        private Label lblPageNumber;
        private Button btnNextPage;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Label label1;
        private TextBox txtboxBookTitle;
        private TextBox txtboxAuthorName;
        private Label label2;
        private Button btnExportBooks;
        private Button btnSearchBooks;
        private Button btnImportBooks;
    }
}
