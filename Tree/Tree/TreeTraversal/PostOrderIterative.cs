using System.Collections;
using DsaPreparation.Tree.Tree;

namespace Tree.Tree.TreeTraversal
{
    public class PostOrderIterative
    {
        public 
            List<int> PostOrderTravesalIterative(TreeNode root)
        {
            List<int> list = new();
            Stack<TreeNode> stack = new();
            while (stack.Count>0 || root != null)
            {
                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                else
                {
                    TreeNode temp = stack.Peek().right;
                    if (temp == null)
                    {
                        temp = stack.Pop();
                        list.Add(temp.val);
                        while (stack.Count > 0 && temp == stack.Peek().right)
                        {
                            temp = stack.Pop();
                            list.Add(temp.val);
                        }
                    }
                    else
                    {
                        root = temp;
                    }
                }
            }

            return list;
        }
    }
}
