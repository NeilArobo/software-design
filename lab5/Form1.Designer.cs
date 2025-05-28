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
            txtboxAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            btnShowBooks = new Button();
            btnDeleteBook = new Button();
            btnSearchBook = new Button();
            SuspendLayout();
            // 
            // txtboxAuthorName
            // 
            txtboxAuthorName.Location = new Point(114, 12);
            txtboxAuthorName.Name = "txtboxAuthorName";
            txtboxAuthorName.Size = new Size(237, 27);
            txtboxAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(114, 63);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(237, 27);
            txtBookTitle.TabIndex = 1;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(367, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(421, 344);
            listBoxBooks.TabIndex = 2;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(114, 126);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(108, 52);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 15);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 4;
            label1.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 63);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Title:";
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(243, 126);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(108, 52);
            btnShowBooks.TabIndex = 6;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(114, 196);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(108, 52);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(243, 196);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(108, 52);
            btnSearchBook.TabIndex = 8;
            btnSearchBook.Text = "Search Book";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 369);
            Controls.Add(btnSearchBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnShowBooks);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtboxAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxAuthorName;
        private TextBox txtBookTitle;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Label label1;
        private Label label2;
        private Button btnShowBooks;
        private Button btnDeleteBook;
        private Button btnSearchBook;
    }
}
