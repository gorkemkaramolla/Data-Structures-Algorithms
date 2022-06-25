class program
{
    public static void Main(string[] args)
    {
        int[] array = { 3, 2, 3, 1, 4, 0, -12, 33, 5 };

        // SelectionSort<int>.Sort(array);
        // InsertionSort<int>.Sort(array);
        BubbleSort<int>.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}