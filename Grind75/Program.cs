// See https://aka.ms/new-console-template for more information
using Grind75.BinaryTree;
using Grind75.DynamicProgramming;

namespace Grind75
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Subsets( new int[] {1, 2, 3}));
            //Console.WriteLine(Solution(new List<int>() { -2, 1, -3, 1 }));

            Console.ReadKey();
        }

        public static IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Backtrack(result, new List<int>(), nums);
            return result;
        }

        private static void Backtrack(List<IList<int>> result, List<int> tempList, int[] nums)
        {
            result.Add(new List<int>(tempList));

            foreach (var num in nums)
            {
                if (tempList.Contains(num))
                    continue;

                tempList.Add(num);
                Backtrack(result, tempList, nums);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }

        public static int MaximumSetSize(int[] A, int[] B)
        {
            int n = A.Length / 2;

            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            Dictionary<int, int> dict2 = new Dictionary<int, int>();

            foreach (int candyType in A)
            {
                if (dict1.ContainsKey(candyType))
                    dict1[candyType]++;
                else
                    dict1[candyType] = 1;
            }

            foreach (int candyType in B)
            {
                if (dict2.ContainsKey(candyType))
                    dict2[candyType]++;
                else
                    dict2[candyType] = 1;
            }

            int uniqueValues1 = 0, uniqueValues2 = 0, commonValues = 0;

            foreach (var item in dict1)
            {
                if (!dict2.ContainsKey(item.Key))
                    uniqueValues1++;
                else
                    commonValues++;
            }

            foreach (var item in dict2)
            {
                if (!dict1.ContainsKey(item.Key))
                    uniqueValues2++;
            }

            int left1 = Math.Max(0, Math.Min(n - uniqueValues1, commonValues));
            int left2 = Math.Max(0, Math.Min(n - uniqueValues2, commonValues));

            return Math.Min(n, uniqueValues1) + Math.Min(n, uniqueValues2) + Math.Min(left1 + left2, commonValues);
        }

        public static  int CanFormSquare(int A, int B)
        {
            int largestSide = 0;

            largestSide = Math.Max(largestSide, B / 4);

            if (A >= (B / 3))
                largestSide = Math.Max(largestSide, B / 3);

            if (A >= 2 * (B / 2))
                largestSide = Math.Max(largestSide, B / 2);

            if (B >= (A / 3))
                largestSide = Math.Max(largestSide, A / 3);

            largestSide = Math.Max(largestSide, A / 4);

            return largestSide;
        }

        public static int Solution(List<int> A)
        {
            int count = A.Count;
            int ans = 0;

            if (count == 1)
                ans = -1 * Math.Min(0, A[0]);

            int diff;

            if (count > 1 && (A[0] + A[1]) < 0)
            {
                A[1] += diff = Math.Abs(A[0] + A[1]);
                ans += diff;
            }

            if (count > 2 && (A[count - 1] + A[count - 2]) < 0)
            {
                A[count - 2] += diff = Math.Abs(A[count - 1] + A[count - 2]);
                ans += diff;
            }

            for (int i = 1; i < count - 1; ++i)
            {
                if (A[i - 1] + A[i] + A[i + 1] >= 0)
                    continue;
                diff = Math.Abs(A[i - 1] + A[i] + A[i + 1]);
                A[i + 1] += diff;
                ans += diff;
            }

            return ans;
        }

        public static int MinSwaps(string s)
        {
            List<int> reds = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    reds.Add(i);
                }
            }

            int redCount = reds.Count;
            if (redCount == 0)
            {
                return 0;
            }

            int startIndex = 0;
            int endIndex = redCount - 1;
            int count = 0;

            while (startIndex < endIndex)
            {
                count += reds[endIndex] - reds[startIndex] - endIndex + startIndex;
                startIndex++;
                endIndex--;
            }

            return count > Math.Pow(10, 9) ? -1 : count;
        }
    }
}

