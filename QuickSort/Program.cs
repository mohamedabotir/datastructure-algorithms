using quicksort;
int[] data = { 5, 1, 3, 4, 10, 12, 7 };
var QuickSort = new QuickSort();
QuickSort.Sort(data, 0, data.Length - 1);

foreach (var item in data)
{
    Console.WriteLine(item);
}