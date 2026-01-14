namespace TwoPointers.TwoSumProblems
{
    public class TwoSumIV_InputIsBST
    {
        HashSet<int> hs = new();
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
                return false;
            if (FindTarget(root.left, k) || hs.Contains(k - root.val))
                return true;
            hs.Add(root.val);
            return FindTarget(root.right, k);
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
