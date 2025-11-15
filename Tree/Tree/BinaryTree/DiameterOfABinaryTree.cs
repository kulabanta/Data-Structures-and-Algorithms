using DsaPreparation.Tree.Tree;

namespace Tree.Tree.TreeTraversal
{
    public class DiameterOfABinaryTree
    {
        private int res = 0;
        private int DiameterRec(TreeNode root)
        {
            if (root == null)
                return 0;
            int p = 0;
            int lh = 0, rh = 0;
            if (root.left != null)
            {
                lh = DiameterRec(root.left);
            }
            if (root.right != null)
            {
                rh = DiameterRec(root.right);
            }
            res = Math.Max(res, lh + rh);
            return 1 + Math.Max(lh, rh);
        }
        public int DiameterOfBinaryTree(TreeNode root)
        {
            DiameterRec(root);
            return res;
        }
    }
}
