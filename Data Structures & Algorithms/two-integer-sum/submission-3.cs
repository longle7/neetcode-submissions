public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var myDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int comp = target - nums[i];

            if (myDict.ContainsKey(comp)) return new int[] {myDict[comp], i};

            myDict[nums[i]] = i;
        }

        return new int[] {-1, -1};
    }
}
