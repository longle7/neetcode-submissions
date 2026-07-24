public class Solution
{
    public int[] SortArray(int[] nums)
    {
        if (nums.Length <= 1) return nums;

        int mid = nums.Length / 2;
        int[] left = SortArray(nums[0..mid]);
        int[] right = SortArray(nums[mid..]);

        return Merge(left, right);

    }

    private static int[] Merge(int[] left, int[] right)
    {
        int[] res = new int[left.Length + right.Length];

        int leftPos = 0;
        int rightPos = 0;
        int resPos = 0;

        while (leftPos < left.Length && rightPos < right.Length)
            res[resPos++] = left[leftPos] <= right[rightPos] ? left[leftPos++] : right[rightPos++];

        while (leftPos < left.Length) res[resPos++] = left[leftPos++];
        while (rightPos < right.Length) res[resPos++] = right[rightPos++];

        return res;
    }
}