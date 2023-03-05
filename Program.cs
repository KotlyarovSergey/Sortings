// 1. Create new array
// 2. Sort with any method
// 3. Output the results
// 4. Renturn step 2-3 to next method

const long ARRAYSIZE = 1124;
const int MINARRAYVALUE = 0;
const int MAXARRAYVALUE = 1000; //int.MaxValue;

//------------------------------------------------------------------------------------------------------------------------

void PrintArray(int[] array)
{
    for (int n = 0; n < 10; n++)
        Console.Write($"{array[n]} ");
    Console.Write(" .... ");
    for (int n = array.Length - 10; n < array.Length; n++)
        Console.Write($"{array[n]} ");
}


// Creates an array with the size of "arraySize" elements of type Int
// and fill it an random units
int[] InitialArray(long arraySize)
{
    //int[] newArray = {11, 30, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29};
    //int[] newArray = { 94, 26, 8, 96, 70, 56, 81, 78, 2, 88, 95, 0 };
    
    int[] newArray = new int[arraySize];

    for (long i = 0; i < arraySize; i++)
    {
        newArray[i] = new Random().Next(MINARRAYVALUE, MAXARRAYVALUE);
    }
    
    return newArray;
}


//                         =============== Bubble Sort ================
long BubbleSort(int[] unsortedArray)
{
    long movingCount = 0;           // count of elements mooving
    int[] newArray = new int[unsortedArray.Length];         // create new array
    Array.Copy(unsortedArray, newArray, unsortedArray.Length);      // copy data to new array

    int iterateCount = 0;               // count of iteration into cicles
    long last = newArray.Length - 1;    // last element of array is respective start of sorted array
    bool isNotSorted = true;        // flag to idicate that array not sorted yet
    while (last > 0)        // use before sorted part of array not achieve first element of array
    {
        isNotSorted = false;
        for (long i = 0; i < last; i++)     // check elements from first to begining sorted part
        {
            if (newArray[i] > newArray[i + 1])
            {
                (newArray[i], newArray[i + 1]) = (newArray[i + 1], newArray[i]);
                isNotSorted = true;
                movingCount++;
            }
            iterateCount++;
        }
        if (!isNotSorted) break;
        last--;    // decrese index of start sortet part of array
    }

    PrintArray(newArray);
    Console.WriteLine($"Count of mooving = {movingCount}, Iteration = {iterateCount}");

    return movingCount;
}

//                         =============== Selection Sort ================
long SelectionSort(int[] unsortedArray)
{
    long movingCount = 0;           // count of elements mooving
    int[] newArray = new int[unsortedArray.Length];     // create new array
    Array.Copy(unsortedArray, newArray, unsortedArray.Length);      // copy data to new array

    long iterateCount = 0;               // count of iteration into cicles
    for (long i = 0; i < newArray.Length - 1; i++)
    {
        
        long indexMinElement = i;      // 
        for (long j = i + 1; j < newArray.Length; j++)
        {
            if (newArray[j] < newArray[indexMinElement])
                indexMinElement = j;
            iterateCount++;
        
        }
        if (indexMinElement != i)
        {
            (newArray[i], newArray[indexMinElement]) = (newArray[indexMinElement], newArray[i]);
            movingCount++;
        }
    }

    PrintArray(newArray);
    Console.WriteLine($"Count of mooving = {movingCount}, Iteration = {iterateCount}");
    return movingCount;
}

//------------------------------------------------------------------------------------------------------------------------

Console.WriteLine();

// create new array
int[] unsortedArray = InitialArray(ARRAYSIZE);


Console.WriteLine("Unsorted Array");
Console.WriteLine($"Length: {ARRAYSIZE}. Range: {MINARRAYVALUE} - {MAXARRAYVALUE}");
long i = 0;
while (i < 12)
{
    Console.Write($"{unsortedArray[i]} ");
    i++;
}
Console.Write(".... ");
i = unsortedArray.Length - 12;
while (i < unsortedArray.Length)
{
    Console.Write($"{unsortedArray[i]} ");
    i++;
}
Console.WriteLine();
Console.WriteLine();

// sorting
Console.WriteLine("      Bubble Sort:");

long movingCount = BubbleSort(unsortedArray);
Console.WriteLine($"It use {movingCount} movings and lost any time");
Console.WriteLine();

Console.WriteLine("     Selection Sort:");
movingCount = SelectionSort(unsortedArray);
Console.WriteLine($"It use {movingCount} movings and lost any time");
Console.WriteLine();