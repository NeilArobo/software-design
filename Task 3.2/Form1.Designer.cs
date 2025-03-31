namespace Task_3._2
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
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            txtboxBase = new TextBox();
            txtboxExponent = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 167);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 214);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Exponent:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(368, 261);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result:";
            // 
            // txtboxBase
            // 
            txtboxBase.Location = new Point(318, 164);
            txtboxBase.Name = "txtboxBase";
            txtboxBase.Size = new Size(248, 27);
            txtboxBase.TabIndex = 3;
            // 
            // txtboxExponent
            // 
            txtboxExponent.Location = new Point(318, 211);
            txtboxExponent.Name = "txtboxExponent";
            txtboxExponent.Size = new Size(248, 27);
            txtboxExponent.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(235, 257);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtboxExponent);
            Controls.Add(txtboxBase);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Recursive Power Calculation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblResult;
        private TextBox txtboxBase;
        private TextBox txtboxExponent;
        private Button button1;
    }
}
