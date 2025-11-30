using DsaPreparation.Tree.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Binary_Search_Tree
{
    internal class KthLargestInBST
    {
        private int res = -1, cnt = 0;
        private void KthLargestInOrder(TreeNode root, int k)
        {
            if (root == null)
                return;
            KthLargestInOrder(root.right, k);
            cnt++;
            if (cnt == k)
            {
                res = root.val;
                return;
            }
            KthLargestInOrder(root.left, k);
        }
        public int KthLargest(TreeNode root, int k)
        {
            // dt = new();
            // Preprocess(root);
            // return KthSmallestRec(root,k);
            KthLargestInOrder(root, k);
            return res;
        }
    }
}
