using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBinaryTree
{
    public class Integer
    {
        public Int32 Value { get; set; }
        public Integer()
        {

        }
        public Integer (Int32 value) { Value = value; }
        public static implicit operator Integer (Int32 x) { return new Integer(x); }
        public static implicit operator Int32 (Integer x) { return x.Value; }
        public override string ToString()
        {
            return String.Format("Integer ({0})", Value);
        }
    }

}
