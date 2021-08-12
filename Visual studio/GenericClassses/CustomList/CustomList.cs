using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class CustomList<T> where T : IComparable//,IEnumerable
    {
        public int Count { get; private set; }
        private List<T> data;
        public CustomList()
        {
            data = new List<T>();
            Count = 0;
        }

        public void Add(T item)
        {
            this.data.Add(item);
            this.Count++;
        }
        public T Remove(int index)
        {
            var rem = this.data[index];
            //this.data.RemoveAt(this.Count - 1);
            this.data.Remove(rem);
            this.Count--;
            return rem;
        }
        public bool Contains(T element)
        {
            return this.data.Contains(element);
        }

        public void Swap(int first, int second)
        {
            var temp = this.data[first];
            this.data[first] = this.data[second];
            this.data[second] = temp;
        }
        public int CounGreaterThan(T element)
        {
            int count = 0;
            foreach (var item in this.data)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void Sort()
        {
            this.data = this.data.OrderBy(a => a).ToList();
          
        }
        public T Max()
        {
            return this.data.Max();
        }
        public T Min()
        {
            return this.data.Min();
        }

        public override string ToString()
        {
            string temp = null;
            foreach (var item in this.data)
            {
                string str = $"{item}";
                temp += str;
            }
            return temp;
        }
        public void Print()
        {
            foreach (var item in this.data)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}
