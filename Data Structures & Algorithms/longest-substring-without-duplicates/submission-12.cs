public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var myMap = new HashSet<char>();
        int left = 0;
        int res = 0;

        foreach (var c in s)
        {
            while (myMap.Contains(c))
            {
                myMap.Remove(s[left]);
                left++;
            }
            myMap.Add(c);

            res = Math.Max(res, myMap.Count());
        }

        return res;
    }
}
