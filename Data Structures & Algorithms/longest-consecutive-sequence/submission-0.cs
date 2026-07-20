public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> myMap = new HashSet<int>();

        foreach (var n in nums)
        {
            myMap.Add(n);
        }

        int longestSeq = 0;
        int curSeq = 0;
        foreach (var n in myMap)
        {
            int curNum = n;
            while (myMap.Contains(curNum++)) curSeq++;
            longestSeq = Math.Max(longestSeq, curSeq);
            curSeq = 0;
        }

        return longestSeq;
    }
}