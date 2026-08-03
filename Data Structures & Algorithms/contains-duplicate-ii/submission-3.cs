public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var myMap = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (myMap.Contains(nums[i])) return true;

            myMap.Add(nums[i]);

            if (myMap.Count > k) myMap.Remove(nums[i - k]);
        }

        return false;
    }
}