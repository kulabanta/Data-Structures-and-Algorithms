using DsaPreparation.Tree.Tree;

namespace Tree.Tree.TreeTraversal
{
    public class PreInPostOrderInSingleStackIteration
    {
        public IList<IList<int>> TreeTraversal(TreeNode root)
        {
            List<IList<int>> res = new();
            res.Add(new List<int>()); //preorder list
            res.Add(new List<int>()); //inorder list
            res.Add(new List<int>()); //postorder list
            Stack<Tuple<TreeNode, int>> st = new();
            st.Push(Tuple.Create(root, 1));

            while(st.Count>0)
            {
                Tuple<TreeNode, int> temp = st.Pop();
                res[temp.Item2 - 1].Add(temp.Item1.val);
                if (temp.Item2 == 3)
                    continue;
                st.Push(Tuple.Create(temp.Item1, temp.Item2 + 1));
                if(temp.Item2 == 1)
                {
                    if(temp.Item1.left != null)
                        st.Push(Tuple.Create(temp.Item1.left, 1));
                }
                if (temp.Item2==2)
                {
                    if (temp.Item1.right != null)
                        st.Push(Tuple.Create(temp.Item1.right, 1));
                }
            }
            return res;
        }
    }
}
