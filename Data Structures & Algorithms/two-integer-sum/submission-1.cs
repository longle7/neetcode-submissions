public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var myDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int comp = target - nums[i];

            // if the comp isn't in the dict - add int
            if (!myDict.ContainsKey(comp)) myDict.Add(nums[i],i);
            // else return the current element index and the comp index
            else return new int[] {myDict[comp], i};
        }

        return new int[] {0};
    }
}
