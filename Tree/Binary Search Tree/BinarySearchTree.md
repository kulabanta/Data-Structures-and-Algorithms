# 🌳 Binary Search Tree (BST)

A  `Binary Search Tree (BST)` is a special type of binary tree that stores data in a structured way to allow `fast search, insertion, and deletion`.

## 📌 Definition

A `Binary Search Tree` is a `binary tree` where:
- Each node contains a `key` (value).
- The `left` subtree of a node contains only **nodes with keys less than the node’s key**.
- The `right` subtree of a node contains only **nodes with keys greater than the node’s key**.
- No duplicate values (in standard BST).

This property must hold for every node in the tree.

## 🧩 Structure of a Node
```css
Node
 ├── value
 ├── left child
 └── right child

```
```markdown
      8
     / \
    3   10
   / \    \
  1   6    14
```

## ⭐ Key Operations in a BST
1. **Search**<br>
    Compare the target value with the root.

    - If equal → return the node.

    - If smaller → search in the left subtree.

    - If larger → search in the right subtree.

    Time complexity:

    1. Best/Average: O(log n)

    2. Worst (skewed tree): O(n)

2. **Insertion**

    Compare the new value with the nodes starting from the root.

    - Move left or right based on value.

    - Insert at the first null position.

    Time complexity:

    1. O(log n) average

    2. O(n) worst

3. **Deletion**

    Three cases:

    1. Node with no children → remove directly.

    2. Node with one child → replace node with its child.

    3. Node with two children →

        -   Find inorder successor (smallest value in the right subtree).

        - Replace the node’s value.

        - Delete the successor.

## 🧭 Tree Traversal in BST
**✔ Inorder Traversal (Left → Root → Right)**

- Outputs values in sorted order.

- Very important property of BST.

**✔ Preorder Traversal (Root → Left → Right)**

- Useful for copying/cloning the tree.

**✔ Postorder Traversal (Left → Right → Root)**

- Useful for deleting/freeing the tree.

## 📈 Time Complexities
| Operation | Best/Average | Worst |
| --------- | ------------ | ----- |
| Search    | O(log n)     | O(n)  |
| Insert    | O(log n)     | O(n)  |
| Delete    | O(log n)     | O(n)  |

## 🪄 Balanced vs Unbalanced BST
1. **Unbalanced BST**: Height can become n, making operations slow.

2. **Balanced BST (AVL, Red-Black Tree)**: Keeps height log n, ensuring fast operations.

## ✅ Summary

1. A `Binary Search Tree` is a binary tree with ordering properties that allow efficient searching.

2. Key rule:
    -  Left < Node < Right

3. Supports fast search, insert, and delete (O(log n)) if balanced.

4. Inorder traversal of a BST always gives a sorted list.
