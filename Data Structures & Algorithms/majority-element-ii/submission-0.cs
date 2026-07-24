public class Solution
{
    public List<int> MajorityElement(int[] nums)
    {
        // element - count
        var myDict = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (!myDict.ContainsKey(n)) myDict.Add(n, 1);
            else myDict[n]++;
        }

        return myDict.Where(k => k.Value > nums.Length / 3)
            .Select(k => k.Key)
            .ToList();
    }
}