using DsaPreparation.Tree;
using DsaPreparation.Tree.Tree;
using DsaPreparation.Tree.Tree.SideViews;
using Tree.Tree.TreeTraversal;

namespace Tree
{
    public class TreeSolution
    {
        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            LeftViewBinaryTree leftView = new LeftViewBinaryTree();
            var result = leftView.GetLeftViewOfBinaryTree(root);
            foreach (var val in result)
            {
                Console.WriteLine(val);
            }
        }

    }
}