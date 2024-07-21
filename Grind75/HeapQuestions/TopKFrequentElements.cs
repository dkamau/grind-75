namespace LeetCode75.HeapQuestions
{
    internal static class TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (counter.ContainsKey(nums[i]))
                    counter[nums[i]]++;
                else
                    counter.Add(nums[i], 1);
            }

            var result = counter.OrderByDescending(n => n.Value).Take(k).Select(n => n.Key);

            return result.ToArray();
        }
    }
}
