
using Datalogi_3_sort;

static void TestBubbleSort()
{
	Console.WriteLine("BubbleSort test");
    Random random = new Random();
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 5000);
    }
    int[] sorted = BubbleSort.Sort(array);

    foreach(var x in sorted)
	{
		Console.WriteLine(x);
	}
	Console.WriteLine("");
}
//TestBubbleSort();

static void TestMerge()
{
	Console.WriteLine("MergeSort test");
    int[] xs = new int[] { -8, -4, 0, 4, 8, 12 };
    int[] ys = new int[] { -3, 3, 5, 7, 15 };
    int[] merged = MergeSort.Merge(xs, ys);

    foreach(var m in merged)
	{
		Console.WriteLine(m);
	}
	Console.WriteLine("");
}
//TestMerge();

static void TestMergeSort()
{
    Console.WriteLine("MergeSort test");
    Random random = new Random();
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 5000);
    }
    int[] sorted = MergeSort.Sort(array);

    foreach (var x in sorted)
    {
        Console.WriteLine(x);
    }
    Console.WriteLine("");
}
//TestMergeSort();

static void TestQuicksort()
{
    Console.WriteLine("Quicksort test");
    Random random = new Random();
    //int[] array = new int[] { 1817, 2627, 3773, 2884, 3764 };
    //int[] array = new int[] { 3020, 4164, 1692, 2424, 1416 };
    int[] array = new int[20];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 5000);
    }
    Console.WriteLine("-- before");
    foreach (var x in array)
    {
        Console.WriteLine(x);
    }
	Console.WriteLine("-- after");
    Quicksort.Sort(array);

    int x0 = array[0] - 1;
    foreach (var x in array)
    {
        Console.WriteLine(x);
		if (x < x0) Console.WriteLine("** OSORTERAT **");
        x0 = x;
    }
    Console.WriteLine("");
}
TestQuicksort();


