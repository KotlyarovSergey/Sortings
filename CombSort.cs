public class CombSort
{
    public static (long swaps, long iteration) Sort(int[] array)
    {
        long swaps = 0;
        long iteration = 0;
        const double factor = 1.247;
        int step = (int)(array.Length / factor);
        while (step > 0)
        {
            for (int i = 0; i < array.Length - step; i++)
            {
                if (array[i] > array[i + step])
                {
                    int temp = array[i];
                    array[i] = array[i + step];
                    array[i + step] = temp;
                    swaps++;
                }
                iteration++;
            }
            step = (int)(step / factor);
        }

        return (swaps, iteration);
    }
}