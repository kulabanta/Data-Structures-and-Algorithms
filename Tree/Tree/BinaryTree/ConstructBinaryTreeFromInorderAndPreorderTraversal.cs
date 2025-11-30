using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    public class ConstructBinaryTreeFromInorderAndPreorderTraversal
    {
        private TreeNode BuildTreeRec(int[] inorder, int[] preorder, int i, int j, ref int curr)
        {
            if (i > j)
                return null;
            TreeNode res = new(preorder[curr]);
            int k = i;
            for (; k <= j; k++)
            {
                if (inorder[k] == preorder[curr])
                    break;
            }
            curr++;
            res.left = BuildTreeRec(inorder, preorder, i, k - 1, ref curr);
            res.right = BuildTreeRec(inorder, preorder, k + 1, j, ref curr);

            return res;

        }
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            int curr = 0;
            return BuildTreeRec(inorder, preorder, 0, preorder.Length - 1, ref curr);
        }
    }
}
