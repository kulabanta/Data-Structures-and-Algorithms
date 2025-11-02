using DsaPreparation.Tree.Tree;

namespace Tree.Tree.TreeTraversal
{
    public class FindPathFromRootToNode
    {
        public string FindPath(TreeNode root, int value)
        {
            string path = FindPathRec(root, value, "");
            if (string.IsNullOrEmpty(path))
                return "No Path";
            return path;
        }
        private string FindPathRec(TreeNode root, int value, string currentPath)
        {
            if (root == null)
                return "";
            currentPath = currentPath + "->" + root.val.ToString();
            if (root.val == value)
                return currentPath;
            string leftPath = FindPathRec(root.left, value, currentPath);
            if (!string.IsNullOrEmpty(leftPath))
                return leftPath;
            string rightPath = FindPathRec(root.right, value, currentPath);
            return rightPath;
        }
    }
}
