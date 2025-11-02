
using DsaPreparation.Tree.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Tree.TreeTraversal
{
    /**
     * solve this using indexing of the nodes
     * if an node has index i ,
     *      then it's left child will have index 2*i
     *      and it's right child will have index 2*i+1
     * for each level , find out the indices of leftmost node and rightmost node
     * difference of index of these nodes will be the width of that level
     * */
    public class MaxWidthOfBinaryTree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            Queue<Tuple<TreeNode, int>> q = new();
            q.Enqueue(Tuple.Create(root, 1));
            int res = 1;
            while (q.Count > 0)
            {
                int n = q.Count;
                int temp = q.Peek().Item2;
                while (n > 0)
                {
                    var p = q.Dequeue();
                    if (n == 1)
                    {
                        res = Math.Max(res, p.Item2 - temp + 1);
                    }
                    n--;
                    if (p.Item1.left != null)
                    {
                        q.Enqueue(Tuple.Create(p.Item1.left, p.Item2 * 2));
                    }
                    if (p.Item1.right != null)
                    {
                        q.Enqueue(Tuple.Create(p.Item1.right, p.Item2 * 2 + 1));
                    }
                }
            }
            return res;
        }
    }
}
