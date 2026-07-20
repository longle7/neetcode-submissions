public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // value - occurances
        var myDict = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (!myDict.ContainsKey(n))
            {
                myDict.Add(n, 1);
            }
            else
            {
                myDict[n]++;
            }
        }

        return myDict
            .OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();
    }
}
