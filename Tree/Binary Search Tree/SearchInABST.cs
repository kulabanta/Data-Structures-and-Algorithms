using DsaPreparation.Tree.Tree;

namespace Tree.Binary_Search_Tree
{
    internal class SearchInABST
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;
            if (root.val == val)
                return root;
            else if (root.val < val)
                return SearchBST(root.right, val);
            else
                return SearchBST(root.left, val);
        }
    }
}
