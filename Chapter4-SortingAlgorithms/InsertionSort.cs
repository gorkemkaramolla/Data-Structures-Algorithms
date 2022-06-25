class InsertionSort<T> where T : IComparable
{
    public static void Sort(T[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int j = i;

            while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
            {
                Swap(array, j, j - 1);
                j--;
            }

        }
    }
    public static void Swap(T[] array, int after, int before)
    {
        T temp = array[after];
        array[after] = array[before];
        array[before] = temp;


    }
}