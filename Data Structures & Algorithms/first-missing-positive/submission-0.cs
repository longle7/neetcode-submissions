public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var myMap = new HashSet<int>() { 1 };

        int res = 1;

        foreach (var n in nums)
        {
            if (n == res)
            {
                if (!myMap.Contains(n)) myMap.Add(n);

                while (myMap.Contains(res))
                {
                    res++;
                }
            }
            else
            {
                if (!myMap.Contains(n)) myMap.Add(n);
            }
        }
        return res;
    }
}