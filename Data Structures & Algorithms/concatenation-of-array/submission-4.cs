public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length * 2];
        int indx = 0;

        for (int i = 0; i < 2; i++)
        {
            foreach (var n in nums)
            {
                ans[indx++] = n;
            }
        }

        return ans;
    }
}