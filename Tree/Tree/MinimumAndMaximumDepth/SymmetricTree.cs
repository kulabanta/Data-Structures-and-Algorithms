using DsaPreparation.Tree.Tree;

namespace DsaPreparation.Tree.MinimumAndMaximumDepth
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            return IsSymmetricRec(root.left, root.right);
        }
        public bool IsSymmetricRec(TreeNode leftNode, TreeNode rightNode)
        {
            if (leftNode == null && rightNode == null)
                return true;
            if (leftNode == null || rightNode == null)
                return false;
            if (leftNode.val != rightNode.val)
                return false;
            return IsSymmetricRec(leftNode.right, rightNode.left) && IsSymmetricRec(leftNode.left, rightNode.right);
        }
    }
}
