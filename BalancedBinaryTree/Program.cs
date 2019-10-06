using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBinaryTree
{
    class Program
    {

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.left.left = null;
            root.left.right = null;
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            Console.WriteLine("{0}", isBalanced(root));
            Console.ReadLine();

        }
        private static Boolean isBalanced(TreeNode root)//From https://www.geeksforgeeks.org/how-to-determine-if-a-binary-tree-is-balanced/
        {
            Int32 lh = 0;
            Int32 rh = 0;

            if (root == null)
            {
                return true;
            }
            lh = height(root.left);
            rh = height(root.right);
            if (Math.Abs(lh - rh) <= 1 && isBalanced(root.left) && isBalanced(root.right))
            {
                return true;
            }
            return false;
        }
        public static int height(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            return 1 + Math.Max(height(node.left), height(node.right));
        }
    }
}
