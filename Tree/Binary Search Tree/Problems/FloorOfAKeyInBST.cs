using DsaPreparation.Tree.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Binary_Search_Tree
{
    internal class FloorOfAKeyInBST
    {
        int floor(TreeNode root, int x)
        {
            int res = -1;

            TreeNode temp = root;

            while (temp != null)
            {
                if (temp.val <= x)
                {
                    res = Math.Max(res, temp.val);
                    temp = temp.right;
                }
                else
                {
                    temp = temp.left;
                }
            }
            return res;
        }
    }
}
