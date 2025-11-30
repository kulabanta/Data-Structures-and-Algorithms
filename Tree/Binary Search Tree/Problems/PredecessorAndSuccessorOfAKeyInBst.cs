using DsaPreparation.Tree.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Binary_Search_Tree
{
    internal class PredecessorAndSuccessorOfAKeyInBst
    {
        private TreeNode pre, suc;
        private void findPreSucRec(TreeNode root, int key)
        {
            if (root == null)
                return;
            if (root.val == key)
            {
                findPreSucRec(root.left, key);
                findPreSucRec(root.right, key);
            }
            else if (root.val < key)
            {
                pre = root;
                findPreSucRec(root.right, key);
            }
            else
            {
                suc = root;
                findPreSucRec(root.left, key);
            }
        }
        public List<TreeNode> findPreSuc(TreeNode root, int key)
        {
            pre = null;
            suc = null;
            findPreSucRec(root, key);
            return new List<TreeNode>() { pre, suc };

        }
    }
}
