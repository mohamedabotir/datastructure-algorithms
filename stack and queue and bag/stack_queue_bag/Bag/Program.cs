using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag
{
    struct types {
       public int id;
       public string name;
        public types(int id,string name) {
            this.id = id;
            this.name = name;
        }
    }
    class bag :IEnumerable{
        types[] bagdata;
        int size;
        int basesize;

        public bag()
        {
        }

        public bag(types[] data) {
            this.size = 0;
            basesize = data.Length;
            bagdata = new types[basesize];
            for (int i = 0; i < basesize; i++)
            {
                bagdata[i] = data[i]; 
            }
            
        }
        public void add(types data) {
            Console.WriteLine(size);
            bagdata[size] = data;    
        }

        public dataEnum  GetEnumerator()
        {
              return new dataEnum(bagdata);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return (IEnumerator)GetEnumerator();
        }
    }

     class dataEnum :IEnumerator
    {
        public types[]datas;
        int position = -1;
        public dataEnum(types []data)  {
            this.datas = data;
        }

        public object Current => getCurrent;
        

        public bool MoveNext()
        {
            position++;
            return (position < datas.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public types getCurrent {

            get{
                try
                {
                    return datas[position];
                }
                catch (IndexOutOfRangeException) {
                    Console.WriteLine("OutOf Bound");
                    throw new  IndexOutOfRangeException();
                }
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            types[] types = new types[3]{
                new types(1,"mohamed"),
                new types(5,"ali"),
                new types(8,"soha")
            };
            
            bag bags = new bag(types);
            bags.add(new types(1, "mmmmmm"));
            foreach (types item in bags)
            {
                Console.WriteLine(item.name + ",");
            }
        }
    }
}
