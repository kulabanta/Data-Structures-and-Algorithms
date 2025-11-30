using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    internal class SymmetricTree
    {
        private bool IsSymmetricRec(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;
            if (left == null || right == null)
                return false;
            if (left.val != right.val)
                return false;

            return IsSymmetricRec(left.right, right.left) &&
                   IsSymmetricRec(left.left, right.right);
        }
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetricRec(root.left, root.right);
        }
    }
}
