using DsaPreparation.Tree.Tree;

namespace Tree.Tree.BinaryTree
{
    internal class BinarySearchTreeIterator
    {
        TreeNode curr;
        public BinarySearchTreeIterator(TreeNode root)
        {
            curr = PreProcess(root);
        }
        public int Next()
        {
            int res = curr.val;
            curr = PreProcess(curr.right);
            return res;
        }
        public bool HasNext()
        {
            return curr != null;
        }
        private TreeNode PreProcess(TreeNode root)
        {
            if (root == null)
                return null;
            TreeNode temp = root;
            while (temp.left != null)
            {
                TreeNode p = temp.left;
                while (p.right != null && p.right != temp)
                {
                    p = p.right;
                }
                if (p.right == null)
                {
                    p.right = temp;
                    temp = temp.left;
                }
                else
                {
                    p.right = null;
                    break;
                }
            }
            return temp;
        }
    }
}
