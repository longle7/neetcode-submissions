public class Solution
{
    public List<List<int>> FourSum(int[] nums, int target)
    {
        List<List<int>> res = new List<List<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for(int j = i + 1; j < nums.Length - 1; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                int left = j + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    long curSum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                    if (curSum > target) right--;
                    else if (curSum < target) left++;
                    else
                    {
                        res.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        while (left < right && nums[left] == nums[left - 1]) left++;
                    }
                }
            }
        }
        return res;
    }
}