public class Solution {
    public void SortColors(int[] nums) {
        var myDict = new Dictionary<int, int>();
        myDict.Add(0,0);
        myDict.Add(1,0);
        myDict.Add(2,0);

        foreach (var n in nums)
        {
            myDict[n]++;
        }

         int i = 0;
        for (int color = 0; color <= 2; color++)
        {
            for (int c = 0; c < myDict[color]; c++)
            {
                nums[i++] = color;
            }
        }
    }
}