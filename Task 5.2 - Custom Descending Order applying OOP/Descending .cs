namespace Task_5._2___Custom_Descending_Order_applying_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] bubbleSort(int[] numbers)
        {
            int length = numbers.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            int[] sortedNumbers = bubbleSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
}
