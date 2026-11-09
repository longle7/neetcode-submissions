public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = 0;
        int count = 0;

        foreach (var n in nums)
        {
            if (count == 0) candidate = n;
            else if (candidate != n) {
                count--;
                continue;
            }
            count++;
        }   
        return candidate;
    }
}