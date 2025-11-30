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
**Approach** : 
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
Time complexity : O(n) <br>
Space complexity : O(1) <br>
Code : [Morris Preorder Traversal](./Tree/TreeTraversal/MorrisPreOrderTraversal.cs)

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
**approach** : 
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
Time complexity : O(n) <br>
Space complexity : O(1) <br>
code : [Morris Inorder Traversal](./Tree/TreeTraversal/MorrisInorderTraversal.cs)
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
## 🌳 Types of Binary Trees
### 1. Full Binary Tree

A **Full Binary Tree (also called a Proper or Strict binary tree)** is a tree where:
- Every node has either 0 or 2 children
- No node has only one child

**✔️ Characteristics**
1. Leaf nodes may appear at different levels
2. Internal nodes always have exactly 2 children

**📘 Example**
```mathematica
        A
      /   \
     B     C
    / \   / \
   D   E F   G
```
### 2. Complete Binary Tree

A **Complete Binary Tree** is a tree where:
- All levels except possibly the last are completely filled
- The last level is filled from left to right without gaps

**✔️ Characteristics**
1. Structured like an array representation of a heap
2. Never has “holes” in the left side

**📘 Example**
```mathematica
        A
      /   \
     B     C
    / \   /
   D   E F
```
### 3. Perfect Binary Tree

A **Perfect Binary Tree** is a tree where:
- All internal nodes have exactly 2 children
- All leaf nodes are at the same depth
- All levels are fully filled

**✔️ Characteristics**
1. Most ideal and symmetric form of binary tree
2. Number of nodes = 2^(h+1) − 1 (where h = height)
3. Number of leaf nodes = 2^h

**📘 Example**
```mathematica
        A
      /   \
     B     C
    / \   / \
   D   E F   G
```
This is perfect because every level is full.

### 4. Balanced Binary Tree

A **Balanced Binary Tree** is a tree where:
- The height difference between the left and right subtrees of any node is at most 1
- Height is kept minimal for efficient operations

**✔️ Characteristics**
1. Ensures `O(log n)` search, insert, delete
2. `AVL Trees` and `Red-Black` Trees are types of balanced trees

**📘 Example (height-balanced)**
```mathematica
        A
      /   \
     B     C
    / \
   D   E
```
Left subtree height = 2<br>
Right subtree height = 1<br>
Difference = 1 → **Balanced**

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
7. [Find Path from Root to Node](./Tree/TreeTraversal/FindPathFromRootToNode.cs)
8. [Maximum width of Binary tree](./Tree/TreeTraversal/MaxWidthOfBinaryTree.cs)
9. [Preorder Inorder Postorder traversal using one stack](./Tree/TreeTraversal/PreInPostOrderInSingleStackIteration.cs)
10. [Vertical order Traversal of binary tree](./Tree/TreeTraversal/VerticalOrderTraversalOfBinaryTree.cs)

## Binary Tree
1. [Binary Tree Max Path Sum](./Tree/BinaryTree/BinaryTreeMaxPathSum.cs)
2. [Lowest Common Ancestor in a Binary tree](./Tree/BinaryTree/LowestCommonAncestorInABinaryTree.cs)
3. [Same Tree](./Tree/BinaryTree/SameTree.cs)
4. [Balanced binary tree](./Tree/BinaryTree/BalancedBinaryTree.cs)
5. [Diameter of a binary tree](./Tree/BinaryTree/DiameterOfABinaryTree.cs) 
