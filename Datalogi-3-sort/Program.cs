
using Datalogi_3_sort;

static void TestBubbleSort()
{
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
}
TestBubbleSort();