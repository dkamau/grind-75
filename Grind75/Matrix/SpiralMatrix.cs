﻿namespace Grind75.Matrix
{
    /// <summary>
    /// Given an m x n matrix, return all elements of the matrix in spiral order.
    /// 
    /// Example 1:
    /// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
    /// Output: [1,2,3,6,9,8,7,4,5]
    /// 
    /// Example 2:
    /// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
    /// Output: [1,2,3,6,9,8,7,4,5]
    /// </summary>
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();

            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return result;

            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int top = 0, bottom = rows - 1, left = 0, right = cols - 1;

            while (top <= bottom && left <= right)
            {
                // Move Right
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }
                top++;  

                // Move Down
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);
                }
                right--;

                // Move Left
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(matrix[bottom][i]);
                    }
                    bottom--;
                }

                // Move Up
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(matrix[i][left]);
                    }
                    left++;
                }
            }

            return result;
        }
    }
}
