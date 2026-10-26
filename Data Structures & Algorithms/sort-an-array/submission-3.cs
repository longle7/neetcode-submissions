public class Solution {
    public int[] SortArray(int[] nums) {
        // base case
        if (nums.Length <= 1) return nums;

        int mid = nums.Length / 2;

        int[] left = SortArray(nums[..mid]);
        int[] right = SortArray(nums[mid..]);

        return Merge(left, right);
    }

    private static int[] Merge(int[] left, int[] right)
    {
        int l = 0;
        int r = 0;
        int i = 0;

        int[] res = new int[left.Length + right.Length];

        while (l < left.Length && r < right.Length)
        {
            res[i++] = (left[l] < right[r]) ? left[l++] : right[r++];
        }

        while (l < left.Length) res[i++] = left[l++];
        while (r < right.Length) res[i++] = right[r++];

        return res;
    }
}