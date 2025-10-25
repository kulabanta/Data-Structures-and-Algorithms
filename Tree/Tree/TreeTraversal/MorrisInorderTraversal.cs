using DsaPreparation.Tree.Tree;

namespace Tree.Tree.TreeTraversal
{
    public class MorrisInorderTraversal
    {
        public List<int> Traverse(TreeNode root)
        {
            List<int> res = new();
            TreeNode curr = root;
            while(curr != null)
            {
                if(curr.left != null)
                {
                    TreeNode temp = curr.left;
                    while(temp.right!=null && temp.right!=curr)
                    {
                        temp = temp.right;
                    }
                    if(temp.right == null)
                    {
                        temp.right = curr;
                        curr = curr.left;
                    }
                    else
                    {
                        res.Add(curr.val);
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
