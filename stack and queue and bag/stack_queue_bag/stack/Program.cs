using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    struct data {
       public int id;
      public  string name;
        public    decimal salary;
        public data(int id ,string name,decimal salary) {
            this.id = id;
            this.salary = salary;
            this.name = name;
        }

    }
    class dStack  :IEnumerable
    {
        int top;
        int size;
        data[] data;
        public dStack(int size)
        {
            top = 0;
            this.size = size;
            data = new data[size];
        }
      public  dStack(data[]dataSet) {
             
            size = dataSet.Length;
            data = new data[size];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = dataSet[i];
                 
            }
            top = size-1;
        }
        public void push(data element)
        {
            if (data.Length == top) {
                Console.WriteLine("==========stack is full");
                return;
            }
            data[top++] = element;
        }
        public data pop() {
            Console.WriteLine($"Top: {top}");
            data temp;
            if (top == data.Length) {
                --top;
                temp = data[top];
                data[top] = default(data);
                return temp;
            }

             temp = data[top];
            data[top--] = default(data);
            return temp;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public datapointer GetEnumerator() {
            return new datapointer(data);
        }
    }
    class datapointer : IEnumerator
    {
        public data[] datas;
        public datapointer(data [] dataSet) {
            datas = dataSet;
        }
        int position = -1;
        public object Current => currentElemnt;

        public bool MoveNext()
        {
            position++;
            return (position < datas.Length);
        }

        public void Reset()
        {
            position = -1;
        }
        public data currentElemnt { get {

                try {
                    return datas[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException();
                }

            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            data[] data = new data[3] {
                new data(1,"ali",250M),
                new data(88,"apolo",87M),
                new data(8,"f12",88M),
              
            };
            dStack stack = new dStack(data);
            foreach (data item in stack)
            {
                Console.WriteLine(item.name +"  ,  ");
            }
            Console.WriteLine(stack.pop().name);
            foreach (data item in stack)
            {
                Console.WriteLine(item.name + "  ,  ");
            }
            Console.WriteLine("======================================");
            data replace = new data();
            replace.id = 15;
            replace.name = "mohamed";replace.salary = 2500M;
            stack.push(replace);
            foreach (data item in stack)
            {
                Console.WriteLine(item.name + "  ,  ");
            }
            stack.push(replace);
            foreach (data item in stack)
            {
                Console.WriteLine(item.name + "  ,  ");
            }
            Console.WriteLine("=================poped");
            Console.WriteLine(stack.pop().name);
            Console.WriteLine(stack.pop().name);
            Console.WriteLine(stack.pop().name);
            Console.WriteLine(stack.pop().name);
        }
    }
}
