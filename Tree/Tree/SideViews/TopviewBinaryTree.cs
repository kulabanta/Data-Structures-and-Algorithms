using DsaPreparation.Tree.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Tree.SideViews
{
    public class TopviewBinaryTree
    {
        public List<int> TopViewIterative(TreeNode root)
        {
            Dictionary<int, int> TopViewDt = new();
            Queue<Tuple<TreeNode, int>> q = new();

            q.Enqueue(Tuple.Create(root, 0));

            while(q.Count>0)
            {
                var temp = q.Dequeue();
                if(!TopViewDt.ContainsKey(temp.Item2))
                {
                    TopViewDt.Add(temp.Item2, temp.Item1.val);
                }
                if(temp.Item1.left!=null)
                {
                    q.Enqueue(Tuple.Create(temp.Item1.left, temp.Item2 - 1));
                }
                if (temp.Item1.right != null)
                {
                    q.Enqueue(Tuple.Create(temp.Item1.right, temp.Item2 + 1));
                }
            }
            return TopViewDt.OrderBy(kv => kv.Key).Select(kv => kv.Value).ToList();
        }
        /**
        * In recursive approach we need to also check for level , as we traverse in Dfs approach 
        * We might get some values in the left hand side , but actual result may also lie on the right hand side
        * */
        public List<int> TopViewDfs(TreeNode root)
        {
            Dictionary<int, int[]> TopViewDt = new();
            TopViewDfsRec(root, 0, 0,TopViewDt);
            return TopViewDt.OrderBy(kv => kv.Key).Select(kv => kv.Value[0]).ToList();
        }
        public void TopViewDfsRec(TreeNode root, int hd,int level, Dictionary<int, int[]> dt)
        {
            if(root == null)
            {
                return;
            }
            if(!dt.ContainsKey(hd) )
            {
                dt.Add(hd, new int[] {root.val,level});
            }
            else if(level < dt[hd][1])
            {
                dt[hd] = new int[] { root.val, level };
            }
            TopViewDfsRec(root.left, hd - 1,level+1, dt);
            TopViewDfsRec(root.right, hd + 1, level+1,dt);
        }
    }
}
