public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var window = new HashSet<int>();
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (right - left > k)
            {
                window.Remove(nums[left++]);
            }
            if (window.Contains(nums[right])) return true;

            window.Add(nums[right]);
        }

        return false;
    }
}