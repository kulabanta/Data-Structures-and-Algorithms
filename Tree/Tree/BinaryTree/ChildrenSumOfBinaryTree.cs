using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    internal class ChildrenSumOfBinaryTree
    {
        public bool isSumProperty(TreeNode root)
        {
            if (root == null)
                return true;
            if (root.left == null && root.right == null)
                return true;
            if (root.val != (root.left != null ? root.left.val : 0) + (root.right != null ? root.right.val : 0))
                return false;
            return isSumProperty(root.left) && isSumProperty(root.right);
        }
    }
}
