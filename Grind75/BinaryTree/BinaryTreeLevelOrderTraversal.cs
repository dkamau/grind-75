namespace Grind75.BinaryTree
{
    /// <summary>
    /// Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
    /// 
    /// Example 1:
    /// Input: root = [3,9,20,null,null,15,7]
    /// Output: [[3],[9,20],[15,7]]
    /// 
    /// Example 2:
    /// Input: root = [1]
    /// Output: [[1]]
    /// 
    /// Example 3:
    /// Input: root = []
    /// Output: []
    /// </summary>
    public class BinaryTreeLevelOrderTraversal
    {
        // TODO: This is wrong. Fix it!
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            result.Add(new List<int>() {
                root.val
            });

            Traverse(root, ref result);

            return result;
        }

        private void Traverse(TreeNode root, ref List<IList<int>> result)
        {
            if (root != null)
            {
                if (root.right != null && root.left != null)
                {
                    result.Add(new List<int>() {
                        root.left.val, root.right.val
                    });

                    Traverse(root.left, ref result);
                    Traverse(root.right, ref result);
                }
                else if (root.left != null)
                {
                    result.Add(new List<int>() {
                        root.left.val
                    });

                    Traverse(root.left, ref result);
                }
                else if (root.right != null)
                {
                    result.Add(new List<int>() {
                        root.right.val
                    });

                    Traverse(root.right, ref result);
                }
            }
        }
    }
}
