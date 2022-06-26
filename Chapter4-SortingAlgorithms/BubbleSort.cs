public static class BubbleSort<T> where T : IComparable
{
    // public static void Sort(T[] array)
    // {
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         for (int j = 0; j < array.Length - 1; j++)
    //         {
    //             if (array[j].CompareTo(array[j + 1]) > 0)
    //             {
    //                 Swap(array, j, j + 1);
    //             }
    //         }
    //     }
    // }
    public static T[] Sort(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            bool isAnyChange = false;
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    isAnyChange = true;
                    Swap(array, j, j + 1);
                }
            }
            if (!isAnyChange)
            {
                break;
            }
        }
        return array;
    }
    public static void Swap(T[] array, int first, int second)
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }
}

