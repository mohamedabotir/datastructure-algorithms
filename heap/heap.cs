using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heap
{
    public class heap
    {
        int[] data;
        public heap(int[] data)
        {
            this.data = data;
        }

        public void heapUp(int index)
        {
            var parent = (index - 1) / 2;
            if (data[parent] > data[index])
            {
                swap(parent, index);
            }
            if (data[index] >= data[parent] || index <= 0)
                return;
            heapUp(index - 1);
        }

        protected void swap(int parent, int index)
        {
            var temp = data[parent];
            data[parent] = data[index];
            data[index] = temp;
        }

    }
}