public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int res = 0;

        while (left <= right)
        {
            int mid = left + (right - left)/2;

            if (nums[mid] == target) return mid;

            if (nums[mid] < target)
            {
                res = mid+ 1;
                left = mid + 1;
            }
            else
            {
                right = mid -1;
            }
        }
        return res;
    }
}