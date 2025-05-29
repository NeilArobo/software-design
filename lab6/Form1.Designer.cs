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
            listBoxBooks = new ListBox();
            txtboxAuthorName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtboxBookTitle = new TextBox();
            btnAddBook = new Button();
            panel1 = new Panel();
            btnDelete = new Button();
            txtboxBookID = new TextBox();
            label3 = new Label();
            btnUpdateBook = new Button();
            panel2 = new Panel();
            btnSearchBook = new Button();
            progressBar = new ProgressBar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(265, 316);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(94, 56);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(430, 23);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(515, 404);
            listBoxBooks.TabIndex = 1;
            // 
            // txtboxAuthorName
            // 
            txtboxAuthorName.Location = new Point(30, 52);
            txtboxAuthorName.Name = "txtboxAuthorName";
            txtboxAuthorName.Size = new Size(338, 27);
            txtboxAuthorName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "Author's Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 95);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "Book Title:";
            // 
            // txtboxBookTitle
            // 
            txtboxBookTitle.Location = new Point(30, 124);
            txtboxBookTitle.Name = "txtboxBookTitle";
            txtboxBookTitle.Size = new Size(338, 27);
            txtboxBookTitle.TabIndex = 4;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(30, 178);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 56);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtboxBookID);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(42, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 150);
            panel1.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(41, 104);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteBook_Click;
            // 
            // txtboxBookID
            // 
            txtboxBookID.Location = new Point(16, 54);
            txtboxBookID.Name = "txtboxBookID";
            txtboxBookID.Size = new Size(144, 27);
            txtboxBookID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 8;
            label3.Text = "Enter Book ID to delete a book.";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(155, 178);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 56);
            btnUpdateBook.TabIndex = 8;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(btnSearchBook);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 243);
            panel2.TabIndex = 9;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(262, 166);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(94, 56);
            btnSearchBook.TabIndex = 10;
            btnSearchBook.Text = "Search Book";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(521, 205);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(362, 29);
            progressBar.TabIndex = 10;
            progressBar.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 450);
            Controls.Add(progressBar);
            Controls.Add(btnUpdateBook);
            Controls.Add(panel1);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(txtboxBookTitle);
            Controls.Add(label1);
            Controls.Add(txtboxAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private TextBox txtboxAuthorName;
        private Label label1;
        private Label label2;
        private TextBox txtboxBookTitle;
        private Button btnAddBook;
        private Panel panel1;
        private Button btnDelete;
        private TextBox txtboxBookID;
        private Label label3;
        private Button btnUpdateBook;
        private Panel panel2;
        private Button btnSearchBook;
        private ProgressBar progressBar;
    }
}
