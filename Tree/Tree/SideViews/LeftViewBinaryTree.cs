using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaPreparation.Tree.Tree.SideViews
{
    public class LeftViewBinaryTree
    {
        public List<int> GetLeftViewOfBinaryTree(TreeNode root)
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
    }
}
