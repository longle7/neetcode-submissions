public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var myMap = new HashSet<int>();
        int l = 0;

        for (int r = 0; r < nums.Length; r++)
        {
            if (r - l > k)
            {
                myMap.Remove(nums[l++]);
            }
            if (myMap.Contains(nums[r])) return true;

            myMap.Add(nums[r]);
        }

        return false;
    }
}