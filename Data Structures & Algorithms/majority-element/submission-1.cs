public class Solution {
    public int MajorityElement(int[] nums) {
        var myDict = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            myDict[n] = myDict.GetValueOrDefault(n) + 1;
            if (myDict[n] > nums.Length/2) return n;
        }

        return -1;
    }
}