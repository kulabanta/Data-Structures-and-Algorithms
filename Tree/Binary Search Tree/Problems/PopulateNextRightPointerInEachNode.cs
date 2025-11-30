using DsaPreparation.Tree.Tree;

namespace Tree.Binary_Search_Tree
{
    internal class TreeNodeWithNextPointer
    {
        public int val;
        public TreeNodeWithNextPointer? left, right,next;
        public TreeNodeWithNextPointer(int value)
        {
            this.val = value;
            left = null;
            right = null;
            next = null;
        }
    }
    internal class PopulateNextRightPointerInEachNode
    {
        public TreeNodeWithNextPointer Connect(TreeNodeWithNextPointer root)
        {
            if (root == null)
                return root;
            if (root.left == null && root.right == null)
                return root;
            root.left.next = root.right;
            if (root.next != null)
            {
                root.right.next = root.next.left;
            }
            root.left = Connect(root.left);
            root.right = Connect(root.right);
            return root;
        }
    }
}
