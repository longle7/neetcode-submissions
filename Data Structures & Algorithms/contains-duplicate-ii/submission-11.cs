public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int left = 0;
        var myMap = new HashSet<int>();

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