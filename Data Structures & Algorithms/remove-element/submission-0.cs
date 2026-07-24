public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int[] res = new int[nums.Length];
        Array.Fill(res, -1);

        int count = 0;
        int pos = 0;

        foreach (var n in nums)
        {
            if (n != val)
            {
                res[pos++] = n;
                count++;
            }
        }
        Array.Copy(res, nums, res.Length);
        return count;

    }
}