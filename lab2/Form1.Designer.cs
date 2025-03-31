namespace lab2
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
            btnCalculateFactorial = new Button();
            lblResult = new Label();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(242, 232);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(94, 39);
            btnCalculateFactorial.TabIndex = 0;
            btnCalculateFactorial.Text = "Calculate";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(374, 241);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(242, 184);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(316, 27);
            txtInput.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateFactorial);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculateFactorial;
        private Label lblResult;
        private TextBox txtInput;
    }
}
