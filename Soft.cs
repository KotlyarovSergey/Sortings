public class Soft
{
    const long ARRAYSIZE = 1124;
    const int MINARRAYVALUE = 0;
    const int MAXARRAYVALUE = 1000; //int.MaxValue;

    //------------------------------------------------------------------------------------------------------------------------

    public static void Print(int[] array)
    {
        if(array.Length < 50)
        {
            Console.WriteLine($"[{String.Join(' ', array)}]");
        }
        else{
        for (int n = 0; n < 10; n++)
            Console.Write($"{array[n]} ");
        Console.Write(" .... ");
        for (int n = array.Length - 10; n < array.Length; n++)
            Console.Write($"{array[n]} ");
        }
    }


    // Creates an array with the size of "arraySize" elements of type Int
    // and fill it an random units
    public static int[] InitialArray(long arraySize)
    {
        //int[] newArray = {11, 30, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29};
        //int[] newArray = { 94, 26, 8, 96, 70, 56, 81, 78, 2, 88, 95, 0 };
  
        return InitialArray(arraySize, MINARRAYVALUE, MAXARRAYVALUE);
    }

    public static  int[] InitialArray(long arraySize, int minValue, int maxValue)
    {
        //int[] newArray = {11, 30, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29};
        //int[] newArray = { 94, 26, 8, 96, 70, 56, 81, 78, 2, 88, 95, 0 };

        int[] newArray = new int[arraySize];

        for (long i = 0; i < arraySize; i++)
        {
            newArray[i] = new Random().Next(minValue, maxValue + 1);
        }

        return newArray;
    }
    public static  int[] SimpleArray(int index = 0)
    {
        switch(index)
        {
            case 1:
                return new int[] { 94, 26, 8, 96, 70, 56, 81, 78, 2, 88, 95, 0 };
            case 2:
                return new int[] { 15, 26, 8, 4, 70, 56, 4, 78, 2, 26, 5, 0 };
            default:
                return new int[] { 4, 6, 8, 9, 7, 0, 8, 7, 2, 3, 9};        
        }
    }
}