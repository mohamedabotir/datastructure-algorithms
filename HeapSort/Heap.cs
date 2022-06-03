namespace algorithms;
public class HeapSort
{

    public HeapSort()
    {

    }

    public void Heapify(int[] arr, int Total, int ParentNode)
    {
        int LeftNode = 2 * ParentNode + 1;
        int RightNode = 2 * ParentNode + 2;
        int NewNode = ParentNode;
        if (arr[LeftNode] > arr[ParentNode] && LeftNode < Total)
        {
            NewNode = LeftNode;
        }

        if (arr[RightNode] > arr[ParentNode] && RightNode < Total)
        {
            NewNode = RightNode;
        }
        if (NewNode != ParentNode)
        {
            swap(arr, ParentNode, NewNode);
            Heapify(arr, Total, NewNode);
        }
    }
    public void swap(int[] arr, int NewNode, int ParentNode)
    {
        int temp = arr[NewNode];
        arr[NewNode] = arr[ParentNode];
        arr[ParentNode] = temp;
    }
    public void Sort(int[] arr)
    {
        int n = arr.Length;

        // Build heap (rearrange array)
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        // One by one extract an element from heap
        for (int i = n - 1; i > 0; i--)
        {
            // Move current root to end
            swap(arr, 0, i);

            // call max heapify on the reduced heap
            Heapify(arr, i, 0);
        }
    }

}