namespace Grind75.BinaryTree
{
    /// <summary>
    /// Given the root of a binary tree, return the length of the diameter of the tree.
    /// The diameter of a binary tree is the length of the longest path between any two nodes in a tree.This path may or may not pass through the root.
    /// The length of a path between two nodes is represented by the number of edges between them.
    /// 
    /// Example 1:
    /// Input: root = [1,2,3,4,5]
    /// Output: 3
    /// Explanation: 3 is the length of the path[4, 2, 1, 3] or [5, 2, 1, 3].
    /// 
    /// Example 2:
    /// Input: root = [1,2]
    /// Output: 1
    /// </summary>
    public class DiameterofBinaryTree
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            int diameter = 0;
            CalculateDiameter(root, ref diameter);
            return diameter;
        }

        private int CalculateDiameter(TreeNode root, ref int diameter)
        {
            if (root == null)
                return 0;

            int leftHeight = CalculateDiameter(root.left, ref diameter);
            int rightHeight = CalculateDiameter(root.right, ref diameter);

            diameter = Math.Max(diameter, leftHeight + rightHeight);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
