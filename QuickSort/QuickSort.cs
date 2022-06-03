using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quicksort
{
    public class QuickSort
    {


        public void Sort(int[] data, int l, int h)
        {
            int low = l;
            int high = h;
            int mid = low + (low + high) / 2;
            int i = low;
            int j = high;
            while (j >= i)
            {
                while (data[mid] < data[j])
                    j--;
                while (data[mid] > data[i])
                    i++;
                if (j >= i)
                {
                    swap(data, i, j);
                }

            }
            if (low < j)
                Sort(data, low, j);
            if (high > i)
                Sort(data, i, high);

        }
        void swap(int[] data, int l, int h)
        {
            int temp = data[l];
            data[l] = data[h];
            data[h] = temp;
        }
    }
}