// 1. Create new array
// 2. Sort with any method
// 3. Output the results
// 4. Renturn step 2-3 to next method

long ArraySize = 1000;
int MinArrayValue = 0;
int MaxArrayValue = 100000; //int.MaxValue;

Console.WriteLine("Hello, World!");
Console.WriteLine();

// Creates an array with the size of "arraySize" elements of type Int
// and fill it an random units
int[] initialArray(long arraySize)
{
    //long arraySize = 1000;
    int[] newArray = new int[arraySize] ;

    long i = 0;
    while(i < arraySize)
    {
        newArray[i] = new Random().Next(MinArrayValue, MaxArrayValue);
        i++;
    }
    return newArray;
}

// create new array
int[] unsortedArray = initialArray(ArraySize);

// sorting


Console.WriteLine("Unsorted Array");
Console.WriteLine($"Length: {ArraySize}. Range: {MinArrayValue} - {MaxArrayValue}");
long i = 0;
while(i < 12)
{
    Console.Write($"{unsortedArray[i]} ");
    i++;
}
Console.Write(".... ");
i = unsortedArray.Length - 12;
while(i < unsortedArray.Length)
{
    Console.Write($"{unsortedArray[i]} ");
    i++;
}
Console.WriteLine();