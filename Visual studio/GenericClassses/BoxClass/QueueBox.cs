using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxClass
{
    public class QueueBox<T>
    {
        private List<T> data;
        public QueueBox()
        {
            data = new List<T>();
        }
        public int Count => this.data.Count;
        public void Add(T item)
        {
            this.data.Add(item);
        }
        public T Remove()
        {
            var rem = this.data.First();
            this.data.RemoveAt(0);
            return rem;
        }
        public override string ToString()
        {
            var removed = Remove();
            string str = $"{removed.GetType().FullName}: {removed}";
            return str;
        }
    }
}
