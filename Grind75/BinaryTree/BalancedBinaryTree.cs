namespace Grind75.BinaryTree
{
    /// <summary>
    /// Given a binary tree, determine if it is height-balanced
    /// 
    /// Example 1:
    /// Input: root = [3,9,20,null,null,15,7]
    /// Output: true
    /// 
    /// Example 2:
    /// Input: root = [1,2,2,3,3,null,null,4,4]
    /// Output: false
    /// 
    /// Example 3:
    /// Input: root = []
    /// Output: true
    /// </summary>
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            return CheckHeight(root) != -1;
        }

        private static int CheckHeight(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = CheckHeight(root.left);
            if (leftHeight == -1)
                return -1;

            int rightHeight = CheckHeight(root.right);
            if (rightHeight == -1)
                return -1;

            int heightDiff = Math.Abs(leftHeight - rightHeight);
            if (heightDiff > 1)
                return -1;

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
