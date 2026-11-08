public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var myMap = new HashSet<int>();
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            if (right - left > k)
            {
                myMap.Remove(nums[left]);
                left++;
            }
            if (myMap.Contains(nums[right])) return true;

            myMap.Add(nums[right]);
        }

        return false;
    }
}