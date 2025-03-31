namespace Task_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFibonacci(int n)
        {

            if (n <= 0)
            {
                MessageBox.Show("Input should be a positive integer.");
                return -1;
            }
            else if (n == 1) return 0;
            else if (n == 2) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = RecursiveFibonacci(int.Parse(txtboxInput.Text));
            if (number != -1)
            {
                lblResult.Text = $"Result: {number}";
            }
            else
            {
                lblResult.Text = "Result:";
                txtboxInput.Text = "";
            }
        }
    }
}
