using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    internal class LargestBSTInBinaryTree
    {
        private int res = 0;
        Tuple<bool, int, int, int> largestBSTRec(TreeNode root)
        {
            if (root == null)
                return Tuple.Create(true,0,Int32.MaxValue,Int32.MinValue);

            Tuple<bool, int, int, int> tl = largestBSTRec(root.left);
            Tuple<bool, int, int, int> tr = largestBSTRec(root.right);

            if (tl.Item1 && tr.Item1)
            {
                if (root.val > tl.Item4 && root.val < tr.Item3)
                {
                    res = Math.Max(res, 1 + tl.Item2 + tr.Item2);
                    int mx = Math.Max(tr.Item4, root.val);
                    int mn = Math.Min(tl.Item3, root.val);
                    return Tuple.Create( true, 1 + tl.Item2 + tr.Item2, mn, mx);
                }

            }
            return Tuple.Create(false, 0, Int32.MinValue, Int32.MaxValue);


        }
        public int largestBst(TreeNode root)
        {
            largestBSTRec(root);
            return res;
        }
    }
}
