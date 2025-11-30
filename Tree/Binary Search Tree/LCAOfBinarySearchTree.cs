using DsaPreparation.Tree.Tree;

namespace Tree.Binary_Search_Tree
{
    internal class LCAOfBinarySearchTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root == p || root == q)
                return root;
            int mn = Math.Min(p.val, q.val);
            int mx = Math.Max(p.val, q.val);
            if (root.val > mx)
                return LowestCommonAncestor(root.left, p, q);
            if (root.val < mn)
                return LowestCommonAncestor(root.right, p, q);
            return root;
        }
    }
}
