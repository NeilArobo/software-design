namespace Task_3._1
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
            txtboxInput = new TextBox();
            lblResult = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtboxInput
            // 
            txtboxInput.Location = new Point(242, 182);
            txtboxInput.Name = "txtboxInput";
            txtboxInput.Size = new Size(316, 27);
            txtboxInput.TabIndex = 8;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(374, 239);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 7;
            lblResult.Text = "Result:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(242, 230);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 39);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtboxInput);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Recursive Fibonacci Sequence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxInput;
        private Label lblResult;
        private Button btnCalculate;
    }
}
