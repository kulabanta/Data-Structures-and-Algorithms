using DsaPreparation.Tree.Tree;

namespace Tree.Tree.TreeTraversal
{
    public class BalancedBinaryTree
    {
        private bool IsBalancedRec(TreeNode root, out int h)
        {
            if (root == null)
            {
                h = 0;
                return true;
            }
            int lh, rh;
            bool LSTBalanced = IsBalancedRec(root.left, out lh);
            bool RSTBalanced = IsBalancedRec(root.right, out rh);
            h = 1 + Math.Max(lh, rh);
            if (!LSTBalanced || !RSTBalanced)
                return false;
            return Math.Abs(lh - rh) <= 1;
        }
        public bool IsBalanced(TreeNode root)
        {
            int h;
            return IsBalancedRec(root, out h);
        }
    }
}
