using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaPreparation.Tree.Tree.SideViews
{
    public class LeftViewBinaryTree
    {
        public List<int> GetLeftViewOfBinaryTreeLevelOrderTraversal(TreeNode root)
        {
            List<int> LeftView = new();
            Queue<TreeNode> queue = new();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                LeftView.Add(queue.Peek().val);
                while(size>0)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }

                    size--;
                }
            }
            return LeftView;
        }
        public List<int> LeftSideViewDfs(TreeNode root)
        {
            List<int> LeftView = new();
            LeftSideViewDfsRec(root, 0, LeftView);
            return LeftView;

        }
        public void LeftSideViewDfsRec(TreeNode root, int level, List<int> LeftView)
        {
            if (root == null)
                return;
            if(level == LeftView.Count)
            {
                LeftView.Add(root.val);
            }
            LeftSideViewDfsRec(root.left, level + 1, LeftView);
            LeftSideViewDfsRec(root.right, level + 1, LeftView);
        }
    }
}
