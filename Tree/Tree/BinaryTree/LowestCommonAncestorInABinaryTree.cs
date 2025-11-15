using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    internal class LowestCommonAncestorInABinaryTree
    {
        private TreeNode res;
        private bool LCARec(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return false;
            bool l = LCARec(root.left, p, q);
            bool r = LCARec(root.right, p, q);
            if (l && r)
            {
                res = root;
            }
            if (root == p || root == q)
            {
                if (l || r)
                {
                    res = root;
                }
                return true;
            }
            return l || r;
        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root == p || root == q)
                return root;
            TreeNode l = LowestCommonAncestor(root.left, p, q);
            TreeNode r = LowestCommonAncestor(root.right, p, q);
            if (l != null && r != null)
                return root;
            return l == null ? r : l;
        }
    }
}
