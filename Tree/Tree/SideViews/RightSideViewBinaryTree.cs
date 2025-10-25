using DsaPreparation.Tree.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Tree.SideViews
{
    public class RightSideViewBinaryTree
    {
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> RightSideView = new();
            RightSideViewRec(root, 0, RightSideView);
            return RightSideView;
        }
        public void RightSideViewRec(TreeNode root, int level, List<int> RightSideView)
        {
            if (root == null)
                return;
            if (level == RightSideView.Count)
            {
                RightSideView.Add(root.val);
            }
            RightSideViewRec(root.right, level + 1, RightSideView);
            RightSideViewRec(root.left, level + 1, RightSideView);
        }

        public List<int> RightSideViewIterative(TreeNode root)
        {
            List<int> RightSideView = new();
            if (root == null)
                return RightSideView;
            Queue<TreeNode> q = new();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int n = q.Count;
                RightSideView.Add(q.Peek().val);
                while (n > 0)
                {
                    TreeNode temp = q.Dequeue();
                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }
                    n--;
                }
            }
            return RightSideView;
        }
    }
}
