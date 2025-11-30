using DsaPreparation.Tree.Tree;

namespace Tree.Binary_Search_Tree
{
    internal class KthSmallestInBST
    {
        Dictionary<int, List<int>> dt;
        private int res = -1, cnt = 0;
        private int Preprocess(TreeNode root)
        {
            if (root == null)
                return 0;
            int nl = Preprocess(root.left);
            int nr = Preprocess(root.right);
            dt.Add(root.val, new List<int> { nl, nr });
            return nl + nr + 1;
        }
        private int KthSmallestRec(TreeNode root, int k)
        {
            if (root == null)
                return 0;
            var l = dt[root.val];
            if ((k - l[0]) == 1)
                return root.val;
            else if (k <= l[0])
                return KthSmallestRec(root.left, k);
            else
                return KthSmallestRec(root.right, k - l[0] - 1);
        }
        private void KthSmallestInOrder(TreeNode root, int k)
        {
            if (root == null)
                return;
            KthSmallestInOrder(root.left, k);
            cnt++;
            if (cnt == k)
            {
                res = root.val;
                return;
            }
            KthSmallestInOrder(root.right, k);
        }
        public int KthSmallest(TreeNode root, int k)
        {
            // dt = new();
            // Preprocess(root);
            // return KthSmallestRec(root,k);
            KthSmallestInOrder(root, k);
            return res;
        }
    }
}
