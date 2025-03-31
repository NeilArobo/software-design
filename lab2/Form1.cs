namespace lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        public int RecursiveFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * RecursiveFactorial(n - 1);

        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtInput.Text);
            int result = RecursiveFactorial(n);
            lblResult.Text = $"Factorial: {result}";
        }
    }
}
