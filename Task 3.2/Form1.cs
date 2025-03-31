namespace Task_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double PowerCalculation(double x, double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n > 0)
            {
                return x * PowerCalculation(x, n - 1);
            }
            else
            {
                return 1 / (x * PowerCalculation(x, -n - 1));
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtboxBase.Text);
            double n = Convert.ToDouble(txtboxExponent.Text);
            double result = PowerCalculation(x, n);
            lblResult.Text = $"Result: {result.ToString()}";
        }
    }
}
