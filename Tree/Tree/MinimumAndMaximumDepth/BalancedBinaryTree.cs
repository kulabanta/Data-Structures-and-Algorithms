using DsaPreparation.Tree.Tree;

namespace DsaPreparation.Tree.MinimumAndMaximumDepth
{
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            int height = Height(root);
            return height == Int32.MaxValue ? false : true;
        }
        public int Height(TreeNode root)
        {
            if (root == null)
                return 0;
            int leftHeight = Height(root.left);
            int rightHeight = Height(root.right);

            if (leftHeight == Int32.MaxValue || rightHeight == Int32.MaxValue || Math.Abs(leftHeight - rightHeight) > 1)
                return Int32.MaxValue;
            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }
}
