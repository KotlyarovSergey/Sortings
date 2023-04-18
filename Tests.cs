public class Test
{
    public static bool IsSortedAscent(int[] data)
    {
        return Check(data, true);
    }

    public static bool IsSortedDescent(int[] data)
    {
        return Check(data, false);
    }

    private static bool Check(int[] data, bool ascent)
    {
        for (int i = 0; i < data.Length - 1; i++)
        {
            if (ascent && data[i] > data[i + 1]) return false;
            else if(!ascent && data[i] < data[i + 1]) return false;
        }
        return true;
    }
}