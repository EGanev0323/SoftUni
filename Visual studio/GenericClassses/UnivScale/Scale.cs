using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivScale
{
    public class Scale<T> where T: IComparable<T>
    {
        public T Left { get; set; }
        public T Right { get; set; }

        public Scale(T left, T right)
        {
            if (left==null)
            {
                throw new ArgumentException(nameof(left));
            }
            if (right==null)
            {
                throw new ArgumentException(nameof(right));
            }
            this.Left = left;
            this.Right = right;
        }
        public T GetHeavier()
        {
            if (Left.CompareTo(Right)>0)
            {
                return Left;
            }
            else if(Left.CompareTo(Right)<0)
            {
                return Right;
            }
            return default(T);
        }
    }
}
