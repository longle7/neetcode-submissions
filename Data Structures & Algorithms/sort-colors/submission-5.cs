public class Solution {
    public void SortColors(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        int i = 0;

        while (i <= right)
        {
            if (nums[i] == 0)
            {
                Swap(ref nums, i, left);
                left++;
            }
            if (nums[i] == 2)
            {
                Swap(ref nums, i, right);
                right--;
                i--;
            }
            i++;
        }
    }

    private static void Swap(ref int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}