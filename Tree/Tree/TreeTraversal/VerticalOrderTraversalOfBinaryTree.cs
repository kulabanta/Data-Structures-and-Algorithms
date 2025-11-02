using DsaPreparation.Tree.Tree;

namespace Tree.Tree.TreeTraversal
{
    public class VerticalOrderTraversalOfBinaryTree
    {
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            Dictionary<int, IList<int>> dt = new();
            Dictionary<int, IList<int>> tempdt = new();
            Queue<Tuple<TreeNode, int>> q = new();
            q.Enqueue(Tuple.Create(root, 0));
            while (q.Count > 0)
            {
                tempdt.Clear();
                int n = q.Count;

                while (n > 0)
                {
                    var p = q.Dequeue();
                    n--;
                    if (p.Item1.left != null)
                    {
                        q.Enqueue(Tuple.Create(p.Item1.left, p.Item2 - 1));
                    }
                    if (p.Item1.right != null)
                    {
                        q.Enqueue(Tuple.Create(p.Item1.right, p.Item2 + 1));
                    }
                    if (!tempdt.ContainsKey(p.Item2))
                    {
                        tempdt.Add(p.Item2, new List<int>() { p.Item1.val });
                    }
                    else
                    {
                        tempdt[p.Item2].Add(p.Item1.val);
                    }
                }
                foreach (var kv in tempdt)
                {
                    var x = kv.Value.ToList();
                    x.Sort();
                    if (dt.ContainsKey(kv.Key))
                    {
                        var y = dt[kv.Key].ToList();
                        y.AddRange(x);
                        dt[kv.Key] = y;
                    }
                    else
                    {
                        dt.Add(kv.Key, x);
                    }
                }
            }
            return dt.OrderBy(kv => kv.Key).Select(kv => kv.Value).ToList();
        }
    }
}
