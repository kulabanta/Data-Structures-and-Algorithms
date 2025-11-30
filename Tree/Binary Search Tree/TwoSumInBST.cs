using DsaPreparation.Tree.Tree;

namespace Tree.Binary_Search_Tree
{
    internal class TwoSumInBST
    {
        public TreeNode SearchNext(TreeNode root, int val)
        {
            if (root == null)
                return null;
            if (root.val == val)
                return root;
            else if (root.val < val)
                return SearchNext(root.right, val);
            else
                return SearchNext(root.left, val);
        }
        public bool FindTarget(TreeNode root, int k)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count() > 0)
            {
                TreeNode p = q.Peek();
                q.Dequeue();
                TreeNode x = SearchNext(root, k - p.val);
                if (x != null && p != x)
                    return true;
                if (p.left != null)
                    q.Enqueue(p.left);
                if (p.right != null)
                    q.Enqueue(p.right);
            }
            return false;

        }
    }
}
