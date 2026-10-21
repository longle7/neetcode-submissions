public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = 0;
        int count = 0;

        foreach (var n in nums)
        {
            if (count == 0) candidate = n;
            count += (n == candidate) ? 1 : -1;
        }

        return candidate;
    }
}