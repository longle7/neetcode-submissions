public class Solution
{
    public void SortColors(int[] nums)
    {
        int[] colors = new int[3];

        foreach (var n in nums)
        {
            colors[n]++;
        }

        int idx = 0;

        for (int i = 0; i < colors[0]; i++) nums[idx++] = 0;
        for (int i = 0; i < colors[1]; i++) nums[idx++] = 1;
        for (int i = 0; i < colors[2]; i++) nums[idx++] = 2;
    }
}