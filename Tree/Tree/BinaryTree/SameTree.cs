using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    internal class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;
            bool l = IsSameTree(p.left, q.left);
            bool r = IsSameTree(p.right, q.right);
            if (l && r && p.val == q.val)
                return true;
            return false;
        }
    }
}
