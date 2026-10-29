public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int i = 0;
        int j = 0;

        while (j <  nums.Length)
        {
            nums[i] = nums[j];
            while (j < nums.Length && nums[i] == nums[j]) j++;
            i++;
        }

        return i;
    }
}