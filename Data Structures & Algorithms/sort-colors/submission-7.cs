public class Solution {
    public void SortColors(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        int i = 0;

        while (i <= r)
        {
            if (nums[i] == 0)
            {
                Swap(nums, i, l);
                l++;
            }
            else if (nums[i] == 2)
            {
                Swap(nums, i, r);
                r--;
                continue;
            }
            i++;
        }
    }

    private static void Swap(int[] nums, int i, int s)
    {
        int temp = nums[i];
        nums[i] = nums[s];
        nums[s] = temp;
    }
}