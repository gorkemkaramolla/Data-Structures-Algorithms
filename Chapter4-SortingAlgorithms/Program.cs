class program
{
    public static void Main(string[] args)
    {
        int[] array = { 3, 33, 12, 1, 4, 5, 6, 7, 8, 9, 10, 11 };

        SelectionSort<int>.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}