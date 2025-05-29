namespace lab6
{
    partial class AsynchronousUpdate
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
            btnUpdateBook = new Button();
            label2 = new Label();
            txtboxBookTitle = new TextBox();
            label1 = new Label();
            txtboxAuthorName = new TextBox();
            lblAuthorName = new Label();
            lblBookTitle = new Label();
            SuspendLayout();
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(180, 179);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 56);
            btnUpdateBook.TabIndex = 13;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 96);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 12;
            label2.Text = "Book Title:";
            // 
            // txtboxBookTitle
            // 
            txtboxBookTitle.Location = new Point(23, 125);
            txtboxBookTitle.Name = "txtboxBookTitle";
            txtboxBookTitle.Size = new Size(405, 27);
            txtboxBookTitle.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 10;
            label1.Text = "Author's Name:";
            // 
            // txtboxAuthorName
            // 
            txtboxAuthorName.Location = new Point(23, 53);
            txtboxAuthorName.Name = "txtboxAuthorName";
            txtboxAuthorName.Size = new Size(405, 27);
            txtboxAuthorName.TabIndex = 9;
            // 
            // lblAuthorName
            // 
            lblAuthorName.AutoSize = true;
            lblAuthorName.Location = new Point(139, 24);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(0, 20);
            lblAuthorName.TabIndex = 14;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(108, 96);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(0, 20);
            lblBookTitle.TabIndex = 15;
            // 
            // AsynchronousUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 259);
            Controls.Add(lblBookTitle);
            Controls.Add(lblAuthorName);
            Controls.Add(btnUpdateBook);
            Controls.Add(label2);
            Controls.Add(txtboxBookTitle);
            Controls.Add(label1);
            Controls.Add(txtboxAuthorName);
            Name = "AsynchronousUpdate";
            Text = "Update Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateBook;
        private Label label2;
        private Label label1;
        public Label lblAuthorName;
        public Label lblBookTitle;
        private TextBox txtboxBookTitle;
        private TextBox txtboxAuthorName;
    }
}