using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.DynamicProgramming
{
    /// <summary>
    /// Given an integer array nums, return true if you can partition the array into two subsets such that the sum of the elements in both subsets is equal or false otherwise.
    /// 
    /// Example 1:
    /// Input: nums = [1,5,11,5]
    /// Output: true
    /// Explanation: The array can be partitioned as [1, 5, 5] and[11].
    /// 
    /// Example 2:
    /// Input: nums = [1,2,3,5]
    /// Output: false
    /// Explanation: The array cannot be partitioned into equal sum subsets.
    /// </summary>
    public class PartitionEqualSubsetSum
    {
        public bool CanPartition(int[] nums)
        {
            int totalSum = 0;

            foreach (var num in nums)
                totalSum += num;

            if (totalSum % 2 != 0)
                return false;

            int targetSum = totalSum / 2;

            bool[] dp = new bool[targetSum + 1];

            dp[0] = true;

            foreach (var num in nums)
            {
                for (int sum = targetSum; targetSum >= num; sum--)
                {
                    dp[sum] = dp[sum] || dp[sum - num];
                }
            }

            return dp[targetSum];
        }
    }
}
