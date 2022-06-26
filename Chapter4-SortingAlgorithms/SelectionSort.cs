class SelectionSort<T> where T : IComparable
{
    public static void Sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            T minValue = array[minIndex];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].CompareTo(minValue) < 0)
                {
                    minIndex = j;
                    minValue = array[j];

                }
            }
            swap(array, minIndex, i);
        }
    }
    private static void swap(T[] array, int arrayFirst, int arraySmaller)
    {
        T temp = array[arrayFirst];
        array[arrayFirst] = array[arraySmaller];
        array[arraySmaller] = temp;
    }
}