public class ShskerSort
{
    public static (long swap, long iteration) Sort(int[] array)
    {
        long iteration = 0;
        long swap = 0;

        long left = 0;
        long right = array.Length - 1;
        while(left < right)
        {
            // Console.WriteLine($"left: {left}, right: {right}");
            // прогон вверх
            for (long i = left; i < right; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swap++;
                }
                iteration++;
            }
            // Console.WriteLine("   " + string.Join(' ', array));
            
            right--;
            // Console.WriteLine($"left: {left}, right: {right}");
            // прогон вниз
            for (long i = right; i > left ; i--)
            {
                if (array[i] < array[i - 1])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    swap++;
                }
                iteration++;
            }
            left++;
            //Console.WriteLine("   " + string.Join(' ', array));
        }

        return (swap, iteration);
    }
}