using DsaPreparation.Tree.Tree;

namespace Tree.Tree.SideViews
{
    public class BottomViewBinaryTree
    {
        public List<int> BottomViewIterative(TreeNode root)
        {
            List<int> BottomView = new();
            Dictionary<int, int> bottomViewDt = new();
            Queue<Tuple<TreeNode, int>> q = new();
            q.Enqueue(Tuple.Create(root, 0));

            while (q.Count > 0)
            {
                var temp = q.Dequeue();
                TreeNode node = temp.Item1;
                if (bottomViewDt.ContainsKey(temp.Item2))
                {
                    bottomViewDt[temp.Item2] = node.val;
                }
                else
                {
                    bottomViewDt.Add(temp.Item2, node.val);
                }
                if (node.left != null)
                {
                    q.Enqueue(Tuple.Create(node.left, temp.Item2 - 1));
                }
                if (node.right != null)
                {
                    q.Enqueue(Tuple.Create(node.right, temp.Item2 + 1));
                }
            }
            return bottomViewDt.OrderBy(kv => kv.Key).Select(kv => kv.Value).ToList();
        }
        /**
          * In recursive approach we need to also check for level , as we traverse in Dfs approach 
          * We might get some values in the left hand side , but actual result may also lie on the right hand side
          * */
        public List<int> BottomViewDfs(TreeNode root)
        {
            List<int> BottomView = new();
            Dictionary<int, int[]> bottomViewDt = new();
            BottomViewRec(root, 0, 0, bottomViewDt);
            foreach (var item in bottomViewDt.OrderBy(x => x.Key))
            {
                BottomView.Add(item.Value[1]);
            }
            return BottomView;
        }
        private void BottomViewRec(TreeNode root, int hd, int level, Dictionary<int, int[]> bottomViewDt)
        {
            if (root == null)
                return;
            if (!bottomViewDt.ContainsKey(hd))
            {
                bottomViewDt.Add(hd, new int[] { root.val, level });
            }
            else if (level > bottomViewDt[hd][1])
            {
                bottomViewDt[hd] = new int[] { root.val, level };
            }
            BottomViewRec(root.left, hd - 1, level + 1, bottomViewDt);
            BottomViewRec(root.right, hd + 1, level + 1, bottomViewDt);
        }
    }
}
