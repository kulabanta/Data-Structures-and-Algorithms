using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    internal class FlattenBinaryTreeToLinkedList
    {
        private TreeNode FlattenRec(TreeNode root)
        {
            if (root == null)
                return null;
            if (root.left == null && root.right == null)
                return root;
            TreeNode l = FlattenRec(root.left);
            TreeNode r = FlattenRec(root.right);
            if (l == null)
            {
                root.right = r;
            }
            else
            {
                TreeNode le = l;
                while (le.right != null)
                    le = le.right;
                root.left = null;
                root.right = l;
                le.right = r;
            }
            return root;
        }
        public void Flatten(TreeNode root)
        {
            FlattenRec(root);
        }
    }
}
