namespace DsaPreparation.Tree.Tree.SideViews
{
    public class FindBottomLeftTreeValue
    {
        private int Height(TreeNode root)
        {
            if (root == null)
                return 0;
            return 1 + Math.Max(Height(root.left), Height(root.right));
        }
        public int FindBottomLeftValue(TreeNode root)
        {
            int height = Height(root);
            Queue<Tuple<TreeNode, int>> q = new();
            q.Enqueue(Tuple.Create(root, 1));
            while (q.Count > 0)
            {
                var temp = q.Dequeue();
                if (temp.Item2 == height)
                    return temp.Item1.val;
                TreeNode node = temp.Item1;
                if (node.left != null)
                {
                    q.Enqueue(Tuple.Create(node.left, temp.Item2 + 1));
                }
                if (node.right != null)
                {
                    q.Enqueue(Tuple.Create(node.right, temp.Item2 + 1));
                }
            }
            return 0;
        }
    }
}
