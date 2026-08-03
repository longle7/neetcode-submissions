public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var myDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (myDict.TryGetValue(nums[i], out var prevIndex) && i - prevIndex <= k) return true;

            myDict[nums[i]] = i;
        }

        return false;
    }
}