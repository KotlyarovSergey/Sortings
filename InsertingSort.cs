public class InsertingSort
{
    public static (long swap, long iteration) Sort(int[] array)
    {
        long iteration = 0;
        long swap = 0;
        for (int i = 1; i < array.Length; i++)
        {
            // Console.WriteLine($" i={i}  [{String.Join(' ', array)}]");
            for (int j = i; j > 0; j--)
            {
                if (array[j] < array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    swap++;
                }
                // Console.WriteLine($"   j={j}  [{String.Join(' ', array)}]");
                iteration++;
            }

        }
        return (iteration, swap);
    }
}