using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCounter
{
    class Box<T> where T:IComparable
    {
        public int Count { get; private set; }
        private List<T> data;
        public Box()
        {
            data = new List<T>();
            Count = 0;
        }

        public void Add(T item)
        {
            this.data.Add(item);
            this.Count++;
        }
        public T Remove()
        {
            var rem = this.data.Last();
            //this.data.RemoveAt(this.Count - 1);
            this.data.Remove(data.Last());
            this.Count--;
            return rem;
        }
        public int BiggerThan(T element)
        {
            int count = 0;
            foreach (var item in this.data)
            {
                if (item.CompareTo(element)>0)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            string temp = null;
            foreach (var item in this.data)
            {
                string str = $"{item.GetType().FullName}: {item}\n";
                temp += str;
            }
            return temp;
        }
        public void Print()
        {
            foreach (var item in this.data)
            {
                Console.WriteLine($"{item.GetType().FullName}:{item}");
            }
        }
    }
}
