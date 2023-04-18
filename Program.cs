
int[] array = Soft.SimpleArray();
Soft.Print(array);

int[] nArr = new int[array.Length];

long iteration;
long swap;

Console.WriteLine("\n      ===  Bubble Sort ===");
array.CopyTo(nArr, 0);
(swap, iteration) = BubbleSort.SortOptimized(nArr);
Console.WriteLine(Test.IsSortedAscent(nArr));
Soft.Print(nArr);
Console.WriteLine($"Swaps: {swap}, itetation: {iteration}");


Console.WriteLine("\n      ===  Shaker Sort ===");
array.CopyTo(nArr, 0);
(swap, iteration) = ShskerSort.Sort(nArr);
Console.WriteLine(Test.IsSortedAscent(nArr));
Soft.Print(nArr);
Console.WriteLine($"Swaps: {swap}, itetation: {iteration}");

Console.WriteLine("\n      ===  Selection Sort ===");
array.CopyTo(nArr, 0);
(swap, iteration) = SelectionSort.Sort(nArr);
Console.WriteLine(Test.IsSortedAscent(nArr));
Soft.Print(nArr);
Console.WriteLine($"Swaps: {swap}, itetation: {iteration}");

Console.WriteLine("\n      ===  Inserting Sort ===");
array.CopyTo(nArr, 0);
(swap, iteration) = InsertingSort.Sort(nArr);
Console.WriteLine(Test.IsSortedAscent(nArr));
Soft.Print(nArr);
Console.WriteLine($"Swaps: {swap}, itetation: {iteration}");

Console.WriteLine("\n      ===  Comb Sort ===");
array.CopyTo(nArr, 0);
(swap, iteration) = CombSort.Sort(nArr);
Console.WriteLine(Test.IsSortedAscent(nArr));
Soft.Print(nArr);
Console.WriteLine($"Swaps: {swap}, itetation: {iteration}");

