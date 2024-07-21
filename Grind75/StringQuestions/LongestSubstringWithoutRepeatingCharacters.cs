using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.StringQuestions
{
    internal static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            HashSet<char> foundChars = new HashSet<char>();

            var chars = s.ToCharArray();
            int lengthOfLongestSubstring = 1;
            int currentCount = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (foundChars.Contains(chars[i]))
                {
                    foundChars.Clear();
                    currentCount = 1;
                }
                else
                {
                    foundChars.Add(chars[i]);
                    currentCount++;
                }

                lengthOfLongestSubstring = Math.Max(lengthOfLongestSubstring, currentCount);
            }

            return lengthOfLongestSubstring;
        }

        public static int MaxArea(int[] height)
        {
            int start = 0;
            int end = height.Length - 1;

            int highestLeft = height[start];
            int highestRight = height[end];

            int maxArea = 1;

            


            return maxArea;
        }
    }
}
