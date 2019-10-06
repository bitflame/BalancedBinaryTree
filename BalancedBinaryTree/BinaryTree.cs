using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBinaryTree
{
    public class BinaryTree
    {
        public TreeNode rootNode;
        public BinaryTree (TreeNode root)
        {
            this.rootNode = root;
        }
        public BinaryTree leftSubTree;
        public BinaryTree rightSubTree;
        public Int32 leftSubTreeSize;
        public Int32 rightSubTreeSize;
        public Int32 getLeftSubTreeSize() { return leftSubTreeSize; }
        public void setLeftSubTreeSize(Int32 value) { this.leftSubTreeSize = value; }
        public Int32 getRightSubTreeSize() { return rightSubTreeSize; }
        public void setRightSubTreeSize(Int32 value) { this.rightSubTreeSize = value; }
        public Boolean IsBalanced(BinaryTree bt)
        {
            maxDepth(bt);
            if (this.rootNode == null)
            {
                return false;
            }
            if (bt.leftSubTreeSize == 0 || bt.rightSubTreeSize == 0)
            {
                return false;
            }
            if (Math.Abs(bt.leftSubTreeSize - bt.rightSubTreeSize) > 1)
            {
                return false;
            }
            return true;
        }
        public Int32 maxDepth(BinaryTree bt)
        {
            this.leftSubTreeSize = maxDepth(bt.leftSubTree);
            this.rightSubTreeSize = maxDepth(bt.rightSubTree);
            return Math.Max(bt.leftSubTreeSize, rightSubTreeSize) + 1;
        }
    }
}
