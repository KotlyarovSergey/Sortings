public class BubbleSort
{
    public static (long swap, long iteration) SortMostSimple(int[] array)
    {
        long iteration = 0;
        long swap = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swap++;
                }
                iteration++;
            }
        }
        return (swap, iteration);
    }
    public static (long swap, long iteration) SortOptimized(int[] unsortedArray)
    {
        long iteration = 0;
        long swap = 0;

        long last = unsortedArray.Length - 1;    // last element of array is respective start of sorted array
        bool isNotSorted = true;        // flag to idicate that array not sorted yet
        while (last > 0)        // use before sorted part of array not achieve first element of array
        {
            isNotSorted = false;
            for (long i = 0; i < last; i++)     // check elements from first to begining sorted part
            {
                if (unsortedArray[i] > unsortedArray[i + 1])
                {
                    (unsortedArray[i], unsortedArray[i + 1]) = (unsortedArray[i + 1], unsortedArray[i]);
                    isNotSorted = true;
                    swap++;
                }
                iteration++;
            }
            if (!isNotSorted) break;
            last--;    // decrese index of start sortet part of array
        }

        return (swap, iteration);
    }
}