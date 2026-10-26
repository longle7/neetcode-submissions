public class Solution {
    public void SortColors(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        int i = 0;

        while (i <= right)
        {
            if (nums[i] == 0)
            {
                Swap(nums, i, left);
                left++;
            }
            else if (nums[i] == 2)
            {
                // Swapped element needs to be checked - incase the 2 is swapped with a 1 or a 2 we don't want that on the left side of "left"
                Swap(nums, i, right);
                right--;
                i--;   
            }
            i++;
        }
    }

    private static void Swap (int[] nums, int posI, int posS)
    {
        int temp = nums[posI];
        nums[posI] = nums[posS];
        nums[posS] = temp;
    }
}