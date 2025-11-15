using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    internal class BinaryTreeMaxPathSum
    {
        private int res = Int32.MinValue;
        private int MaxPathSumRec(TreeNode root)
        {
            if (root == null)
                return 0;
            int lSum = MaxPathSumRec(root.left);
            int rSum = MaxPathSumRec(root.right);
            int p = root.val;
            p = Math.Max(p, root.val + lSum);
            p = Math.Max(p, root.val + rSum);
            p = Math.Max(p, root.val + lSum + rSum);
            res = Math.Max(res, p);
            return Math.Max(root.val, root.val + Math.Max(lSum, rSum));
        }
        public int MaxPathSum(TreeNode root)
        {
            MaxPathSumRec(root);
            return res;
        }
    }
}
