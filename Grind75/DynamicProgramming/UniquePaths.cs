﻿namespace Grind75.DynamicProgramming
{
    /// <summary>
    /// There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.
    /// Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.
    /// The test cases are generated so that the answer will be less than or equal to 2 * 109.
    /// 
    /// Example 1:
    /// Input: m = 3, n = 7
    /// Output: 28
    /// 
    /// Example 2:
    /// Input: m = 3, n = 2
    /// Output: 3
    /// Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
    /// 1. Right -> Down -> Down
    /// 2. Down -> Down -> Right
    /// 3. Down -> Right -> Down
    /// </summary>
    public class UniquePathsSolution
    {
        public int UniquePaths(int m, int n)
        {
            if (m <= 0 || n <= 0)
                return 1;

            int[,] dp = new int[m, n];

            for (int row = 0; row < m; row++)
                dp[row, 0] = 1;

            for (int col = 0; col < n; col++)
                dp[0, col] = 1;

            for (int row  = 1; row < m; row++)
            {
                for (int col = 1; col < n; col++)
                {
                    dp[row, col] = dp[row - 1, col] + dp[row, col - 1];
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}