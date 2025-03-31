namespace Task_2
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
            txtArrayInput = new TextBox();
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            SuspendLayout();
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(242, 182);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(316, 27);
            txtArrayInput.TabIndex = 5;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(374, 239);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(52, 20);
            lblSumResult.TabIndex = 4;
            lblSumResult.Text = "Result:";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(242, 230);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(94, 39);
            btnCalculateSum.TabIndex = 3;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtArrayInput);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Name = "Form1";
            Text = "Recursive Sum of Array of Elements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArrayInput;
        private Label lblSumResult;
        private Button btnCalculateSum;
    }
}
