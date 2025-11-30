using DsaPreparation.Tree.Tree;

namespace Tree.Binary_Search_Tree
{
    internal class ValidBinarySearchTree
    {
        public bool IsValidBSTRec(TreeNode root, out long mn, out long mx)
        {
            if (root == null)
            {
                mn = long.MaxValue;
                mx = long.MinValue;
                return true;
            }

            if (root.left == null && root.right == null)
            {
                mn = root.val;
                mx = root.val;
                return true;
            }
            bool lbst = IsValidBSTRec(root.left, out long lmn, out long lmx);
            bool rbst = IsValidBSTRec(root.right, out long rmn, out long rmx);

            if (!lbst || !rbst)
            {
                mn = long.MinValue;
                mx = long.MaxValue;
                return false;
            }
            if (root.val <= lmx || root.val >= rmn)
            {
                mn = long.MinValue;
                mx = long.MaxValue;
                return false;
            }
            mn = Math.Min(lmn, root.val);
            mx = Math.Max(rmx, root.val);
            return true;
        }
        private bool IsValidBSTRec2(TreeNode root, long mn, long mx)
        {
            if (root == null)
                return true;
            long val = (long)root.val;
            if (val <= mn || val >= mx)
                return false;
            return IsValidBSTRec2(root.left, mn, val) && IsValidBSTRec2(root.right, val, mx);
        }
        public bool IsValidBST(TreeNode root)
        {
            // return IsValidBSTRec(root,out long mn,out long mx);
            return IsValidBSTRec2(root, long.MinValue, long.MaxValue);
        }
    }
}
