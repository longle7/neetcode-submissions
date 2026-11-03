public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        var res = new List<List<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int curSum = nums[i] + nums[left] + nums[right];

                if (curSum > 0) right--;
                else if (curSum < 0) left++;
                else
                {
                    res.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    left++;
                    while (left < right && nums[left] == nums[left - 1]) left++;
                }
            }
        }

        return res;
    }
}
