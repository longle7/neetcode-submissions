public class Solution {
    public int MajorityElement(int[] nums) {
    
        int count = 0;
        int curMaj = nums[0];

        foreach (var n in nums)
        {
            if (n == curMaj) count++;
            else
            {
                count--;

                if (count == 0)
                {
                    count++;
                    curMaj = n;
                }
            }
        }

        return curMaj;
    }
}