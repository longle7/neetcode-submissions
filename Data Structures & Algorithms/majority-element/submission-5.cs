public class Solution {
    public int MajorityElement(int[] nums) {
        int candiate = 0;
        int count = 0;

        foreach (var n in nums)
        {
            if (count == 0) candiate = n;
            
            count += (n == candiate) ? 1 : -1;
        }

        return candiate;
    }
}

// Space O(1)
// Time O(n)