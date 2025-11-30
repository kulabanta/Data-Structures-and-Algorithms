using DsaPreparation.Tree.Tree;

namespace Tree.Binary_Search_Tree
{
    internal class CeilOfKeyInABST
    {
        int ceil(TreeNode root, int x)
        {
            int res = Int32.MaxValue;

            TreeNode temp = root;

            while (temp != null)
            {
                if (temp.val < x)
                {
                    temp = temp.right;
                }
                else
                {
                    res = Math.Min(res, temp.val);
                    temp = temp.left;
                }
            }
            if (res == Int32.MaxValue)
                return -1;
            return res;
        }

    }
}
