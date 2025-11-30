using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    internal class ConstructBinaryTreeFromInorderAndPostorderTraversal
    {
        public TreeNode BuildTreeRec(int[] inorder, int[] postorder, int i, int j, ref int curr)
        {
            if (i > j)
                return null;
            TreeNode res = new(postorder[curr]);
            int k = i;
            for (; k <= j; k++)
            {
                if (inorder[k] == postorder[curr])
                    break;
            }
            curr--;
            res.right = BuildTreeRec(inorder, postorder, k + 1, j, ref curr);
            res.left = BuildTreeRec(inorder, postorder, i, k - 1, ref curr);
            return res;
        }
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            int n = inorder.Length;
            int curr = n - 1;
            return BuildTreeRec(inorder, postorder, 0, n - 1, ref curr);
        }
    }
}
