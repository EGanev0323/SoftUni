using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapInt
{
    public class Box<T>
    {
        private T[] array;
        private int index;

        public Box(int length)
        {
            this.array = new T[length];
            this.index = 0;
        }
        public void Add(T item)
        {
            this.array[index]=item;
            this.index++;
        }
       
        public override string ToString()
        {
            string temp = null;
            foreach (var item in this.array)
            {
                string str = $"{item.GetType().FullName}: {item}\n";
                temp += str;
            }
            return temp;
        }
        public void Swap(int first, int second)
        {
            T temp = this.array[first];
            this.array[first] = this.array[second];
            this.array[second] = temp;
        }
        public void Print()
        {
            foreach (var item in this.array)
            {
                Console.WriteL  ine($"{item.GetType().FullName}:{item}");
            }
        }
    }
}
