using DsaPreparation.Tree.Tree;

namespace Tree.Binary_Search_Tree
{
    internal class ConstructBSTFromPreorderTraversal
    {
        public TreeNode BstFromPreorderRec(int[] preorder, int i, int j)
        {
            if (i > j)
                return null;
            TreeNode root = new TreeNode(preorder[i]);
            int k = i + 1;
            while (k <= j && preorder[k] < preorder[i])
                k++;
            root.left = BstFromPreorderRec(preorder, i + 1, k - 1);
            root.right = BstFromPreorderRec(preorder, k, j);
            return root;

        }
        public TreeNode BstFromPreorder(int[] preorder)
        {
            return BstFromPreorderRec(preorder, 0, preorder.Length - 1);
        }
    }
}
