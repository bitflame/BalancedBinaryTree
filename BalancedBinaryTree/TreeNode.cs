using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBinaryTree
{
    public class TreeNode
    {
        public Int32 val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode() { }//Added this constructor myself
        public TreeNode (Int32 x) { val = x; }
    }
}
