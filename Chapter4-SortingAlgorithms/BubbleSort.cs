public static class BubbleSort<T> where T : IComparable
{
    public static void Sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            // 3 14 15 17 24
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    Swap(array, j, j + 1);
                }
            }
        }
    }
    public static void Swap(T[] array, int first, int second)
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }
}