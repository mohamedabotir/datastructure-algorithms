//b(o) = nlog(n) , space complixty = 1
using algorithms;

int[] arr = { 1, 50, 30, 10, 60, 80 };
var heap = new HeapSort();
heap.Sort(arr);
foreach (var item in arr)
{
    Console.WriteLine(item);
}