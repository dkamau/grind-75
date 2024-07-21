namespace Grind75.BinaryTree
{
    /// <summary>
    /// Given the root of a binary tree, return its maximum depth.
    /// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    /// 
    /// Example 1:
    /// Input: root = [3,9,20,null,null,15,7]
    /// Output: 3
    /// 
    /// Input: root = [1,null,2]
    /// Output: 2
    /// </summary>
    public class MaximumDepthofBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
