namespace Task_5._1___Bubble_Sort_applying_Procedural_Algorithm
{
    public partial class BubbleSort : Form
    {
        public BubbleSort()
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
                    if (numbers[j] > numbers[j + 1])
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

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
