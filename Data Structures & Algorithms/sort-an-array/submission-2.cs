public class Solution {
    public int[] SortArray(int[] nums) {
        // base case
        if (nums.Length <= 1) return nums;

        int mid = nums.Length / 2;
        int[] left = SortArray(nums[..mid]);
        int[] right = SortArray(nums[mid..]);

        return MergeSort(left, right);
    }

    private static int[] MergeSort(int[] left, int[] right)
    {
        int[] res = new int[left.Length + right.Length];

        int resPos = 0;
        int leftPos = 0;
        int rightPos = 0;

        while (leftPos < left.Length && rightPos < right.Length)
            res[resPos++] = left[leftPos] < right[rightPos] ? left[leftPos++] : right[rightPos++];

        // left over values when one side of the array has all elements used
        while (leftPos < left.Length) res[resPos++] = left[leftPos++];
        while (rightPos < right.Length) res[resPos++] = right[rightPos++];

        return res;
    }
}