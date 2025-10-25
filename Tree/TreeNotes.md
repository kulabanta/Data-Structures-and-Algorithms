# Tree Data Structures

## DFS Traversal of Binary Trees

### Preorder Traversal 
root Node -> left child -> right child
#### Iterative approach 
```markdown
```csharp
public class TreeNode{
    public int value;
    public TreeNode left, right;
}
public List<int> PreOrderTraversalIterative(TreeNode root)
{
    List<int> res = new();
    Stack<TreeNode> st = new();
    st.Push(root);

    while(st.Count>0)
    {
        TreeNode temp = st.Pop();
        res.Add(temp.value);
        if(temp.right != null)
            st.Add(temp.right);
        if(temp.left != null)
            st.Add(temp.left);
    }
    return res;
}
```
#### Recursive approach
```markdown
```csharp
public void PreOrderTraversalRecursive(TreeNode root,List<int> result)
{
    if(root == null)
    {
        return;
    }
    res.Add(root.value);
    PreOrderTraversalRecursive(root.left,res);
    PreOrderTraversalRecursive(root.right,res);
}
```

#### Morris Preorder Traversal
    approach : 
        We will create a threaded binary tree , where rightmost node in the left child of a node will point to the node itself and it will be used to go back to the node after left child traversal if finished 
        
        algorithm :

    ``` markdown
    ``` csharp
        if(root.left == null)
        {
            Print(root.value);
            root = root.right;
        }
        else{
            TreeNode temp = root.left;
            while(temp.right != null && temp.right != root)
            {
                temp = temp.right;
            }
            if(temp.right == null)
            {
                Print(root.value);
                // before processing the left child , add root to the result
                temp.right = root;
                root = root.left;
            }
            else{
                temp.right = null;
                root = root.right;
            }
        }
    ```
    Time complexity : O(n)
    Space complexity : O(1)

### Inorder Traversal

left child -> root -> right child

#### Iterative approach
```markdown
```csharp
public class TreeNode{
    public int value;
    public TreeNode left, right;
}
public List<int> InorderTraversalIterative(TreeNode root)
{
    List<int> res = new();
    Stack<TreeNode> st = new();
    TreeNode temp = root;
    while(root != null)
    {
        st.Push(temp);
        temp = temp.left;
    }
    while(st.Count>0)
    {
        TreeNode temp = st.Pop();
        res.Add(temp.value);
        if(temp.right != null)
        {
            temp = temp.right;
            while(temp!=null)
            {
                st.Push(temp);
                temp = temp.left;
            }
        }
    }
    return res;
}
```
#### Recursive approach
```markdown
```csharp
public void InOrderTraversalRecursive(TreeNode root,List<int> result)
{
    if(root == null)
    {
        return;
    }
    InOrderTraversalRecursive(root.left,res);
    res.Add(root.value);
    InOrderTraversalRecursive(root.right,res);
}
```

#### Morris Inorder Traversal
    approach : 
        We will create a threaded binary tree , where rightmost node in the left child of a node will point to the node itself and it will be used to go back to the node after left child traversal if finished 
        
        algorithm :

    ``` markdown
    ``` csharp
        if(root.left == null)
        {
            Print(root.value);
            root = root.right;
        }
        else{
            TreeNode temp = root.left;
            while(temp.right != null && temp.right != root)
            {
                temp = temp.right;
            }
            if(temp.right == null)
            {
                temp.right = root;
                root = root.left;
            }
            else{
                Print(root.value);
                // after processing the left child , add root to the result
                temp.right = null;
                root = root.right;
            }
        }
    ```
    Time complexity : O(n)
    Space complexity : O(1)
### Post order traversal
left child -> right child -> root

#### Iterative approach
```markdown
```csharp
public class TreeNode{
    public int value;
    public TreeNode left, right;
}
public List<int> PostorderTraversalIterative(TreeNode root)
{
    List<int> res = new();
    Stack<TreeNode> st = new();
    Stack<TreeNode> stTemp = new();
    TreeNode temp = root;
    while(st.Count>0)
    {
        TreeNode temp = st.Pop();
        stTemp.Push(temp);
        if(temp.left!=null)
            st.Push(temp.left);
        if(temp.right != null)
            st.Push(temp.right);
    }
    while(stTemp.Count>0)
    {
        res.Add(stTemp.Pop());
    }
    return res;
}
//using single stack
public List<int> PostOrderTraversalIterativeApproach2(TreeNode root)
{
    List<int> res = new();
    Stack<int> st = new();

    while(st.Count > 0 || root!= null)
    {
        if(root!=null)
        {
            st.Add(root);
            root = root.left;
        }
        else{
            TreeNode temp = st.Peek().right;
            if(temp == null)
            {
                temp = st.Peek();
                res.Add(temp);
                while(st.Count> 0 && temp == st.Peek().right)
                {
                    //this is to add the root nodes for which right child traversal is completed .
                    temp = st.Pop();
                    res.Add(temp);
                }
            }
            else{
                root = temp;;
            }
        }
    }
}
```
#### Recursive approach
```markdown
```csharp
public void PostOrderTraversalRecursive(TreeNode root,List<int> result)
{
    if(root == null)
    {
        return;
    }
    PostOrderTraversalRecursive(root.left,res);
    PostOrderTraversalRecursive(root.right,res);
    res.Add(root.value);
}
```

## BFS Traversal
### Level order traversal
travese the binary tree level by level
from root node till leaf nodes
```markdown
```csharp
public List<int> LevelOrder(TreeNode root)
{
    List<int> res = new();
    Queue<TreeNode> q = new();

    q.Enqueue(root);
    
    while(q.Count>0)
    {
        TreeNode temp = q.Dequeue();
        res.Add(temp.value);
        if(temp.left!=null)
            q.Enqueue(temp);
        if(q.right!=null)
            q.Enqueue(temp.right);
    }
    return res;
}

```
### Zigzag level order traversal
```markdown
```csharp
public List<int> ZigZagLevelOrderTraversal(TreeNode root)
{
    List<int> res = new();
    Queue<TreeNode> q = new();
    bool flag = true;
    q.Enqueue(root);
    while(q.Count>0)
    {
        int size = q.Count;
        flag = false;
        while(size-- > 0)
        {
            TreeNode temp = q.Pop();
            res.Add(temp.value);
            if(flag)
            {
                if(temp.left != null)
                    q.Enqueue(temp.left);
                if(temp.right != null)
                    q.Enqueue(temp.right);
            }
            else{
                if(temp.right != null)
                    q.Enqueue(temp.right);
                if(temp.left != null)
                    q.Enqueue(temp.left);
            }
        }
    }
    return res;
        
}
```

## Minimum and Maximum Depth 
**Questions**</br>
1.  [Minimum Depth of Binary Tree](./MinimumAndMaximumDepth/MinimumDepthOfBinaryTree.cs)
2. [Maximum Depth of Binary Tree](./MinimumAndMaximumDepth/MaximumDepthOfBinaryTree.cs)
3. [Same Tree](./MinimumAndMaximumDepth/SameTree.cs)
4. [Symmetric Tree](./MinimumAndMaximumDepth//SymmetricTree.cs)
5. [Balanced Binary Tree](./MinimumAndMaximumDepth/BalancedBinaryTree.cs)


## Side views
1. [Binary Tree Left Side View](./SideViews/LeftViewBinaryTree.cs)
2. [Find Bottom Left Tree Value ](./SideViews/FindBottomLeftTreeValue.cs)
3. [right view of Binary tree](./Tree/SideViews/RightSideViewBinaryTree.cs)
4. [Top view of Binary tree](./Tree/SideViews/TopviewBinaryTree.cs)
5. [Bottom view of Binary tree](./Tree/SideViews/FindBottomLeftTreeValue.cs)
6. [Boundary view of Binary tree](./Tree/SideViews/BoundaryViewBinaryTree.cs)