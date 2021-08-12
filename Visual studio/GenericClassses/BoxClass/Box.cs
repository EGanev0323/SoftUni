using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxClass
{
    public class Box<T>
    {
        private List<T> data;
        public Box()
        {
            data = new List<T>();
        }
        public int Count=>this.data.Count;       
        public void Add(T item)
        {
            this.data.Add(item);
        }
        public T Remove()
        {
            var rem=this.data.Last();
            //this.data.RemoveAt(this.Count - 1);
            this.data.Remove(data.Last());
            return rem;
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
