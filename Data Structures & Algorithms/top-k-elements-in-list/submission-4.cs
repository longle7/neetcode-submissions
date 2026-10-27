public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            count[n] = count.GetValueOrDefault(n) + 1;
        }

        List<int>[] freq = new List<int>[nums.Length + 1];
        foreach (var (n, c) in count)
        {
            freq[c] ??= new List<int>();
            freq[c].Add(n);
        }

        var res = new List<int>();
        for (int i = freq.Length - 1; i > 0; i--)
        {
            if(freq[i] == null) continue;
            if (res.Count < k) res.AddRange(freq[i]);
        }
        return res.ToArray();
    }
}
