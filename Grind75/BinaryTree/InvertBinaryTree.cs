﻿namespace Grind75.BinaryTree
{
    /// <summary>
    /// Given the root of a binary tree, invert the tree, and return its root.
    /// 
    /// Example 1:
    /// Input: root = [4,2,7,1,3,6,9]
    /// Output: [4,7,2,9,6,3,1]
    /// 
    /// Example 2:
    /// Input: root = [2,1,3]
    /// Output: [2,3,1]
    /// </summary>
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}