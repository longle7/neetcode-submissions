public class Solution {
    public void SortColors(int[] nums) {
        if (nums.Length < 2) return;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int lowestElement = nums[i];
            int lowestPos = i;
            int j = i + 1;

            // find the lowest element
            while (j < nums.Length)
            {
                if (nums[j] < lowestElement)
                {
                    lowestElement = nums[j];
                    lowestPos = j;
                }
                j++;
            }

            // swap
            int temp = nums[i];
            nums[i] = nums[lowestPos];
            nums[lowestPos] = temp;
        }
    }
}