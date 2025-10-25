using DsaPreparation.Tree.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Tree.TreeTraversal
{
    public class MorrisPreOrderTraversal
    {
        public List<int> Traverse(TreeNode root)
        {
            List<int> res = new();
            TreeNode curr = root;
            while (curr != null)
            {
                
                if (curr.left != null)
                {
                    TreeNode temp = curr.left;
                    while (temp.right != null && temp.right != curr)
                    {
                        temp = temp.right;
                    }
                    if (temp.right == null)
                    {
                        res.Add(curr.val);
                        temp.right = curr;
                        curr = curr.left;
                    }
                    else
                    {
                        temp.right = null;
                        curr = curr.right;
                    }
                }
                else
                {
                    res.Add(curr.val);
                    curr = curr.right;
                }
            }
            return res;
        }
    }
}
