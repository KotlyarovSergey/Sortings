public class SelectionSort
{

    public static (long swap, long iteration) Sort(int[] array)
    {
        long iteration = 0;
        long swap = 0;

        for (long i = 0; i < array.Length - 1; i++)
        {

            long minimalIndex = i;      // 
            for (long j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minimalIndex])
                    minimalIndex = j;
                iteration++;

            }
            if (minimalIndex != i)
            {
                (array[i], array[minimalIndex]) = (array[minimalIndex], array[i]);
                swap++;
            }
        }

        return (swap, iteration);
    }
}