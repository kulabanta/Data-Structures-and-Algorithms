using DsaPreparation.Tree.Tree;
using DsaPreparation.Tree.Tree.SideViews;

namespace Tree.Tree.SideViews
{
    public class BoundaryViewBinaryTree
    {
        public List<int> BoundaryView(TreeNode root)
        {
            LeftViewBinaryTree leftView = new();
            RightSideViewBinaryTree rightView = new();
            BottomViewBinaryTree bottomView = new();

            List<int> lview = leftView.GetLeftViewOfBinaryTreeLevelOrderTraversal(root);
            List<int> rview = rightView.RightSideViewIterative(root);
            List<int> bview = bottomView.BottomViewIterative(root);

            int leftSkip = 0;
            int ln = lview.Count - 1;
            while (ln >= 0 && lview[ln] != bview[0])
            {
                leftSkip++;
                ln--;
            }
            int rightSkip = 0;
            int rn = lview.Count - 1;
            while (rn >= 0 && rview[rn] != bview[bview.Count-1])
            {
                rightSkip++;
                rn--;
            }
            List<int> boundaryView = lview.SkipLast(leftSkip+1).ToList();
            boundaryView.AddRange(bview);
            boundaryView.AddRange(rview.SkipLast(rightSkip+1).Reverse());
            return boundaryView;
        }
    }
}
