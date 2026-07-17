public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // key = comp : value = index
        var myDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int comp = target - nums[i];

            if (!myDict.ContainsKey(comp)) myDict[nums[i]] = i;
            else
            {
                return new int[] {myDict[comp], i};
            }

        }

        return new int[] { 0 };
    }
}