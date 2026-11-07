public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var myMap = new HashSet<char>();
        int res = -1;

        int left = 0;
        

        for (int right = 0; right < s.Length; right ++)
        {
            while (myMap.Contains(s[right]))
            {
                res = Math.Max(res, myMap.Count());
                myMap.Remove(s[left++]);
                if (left > s.Length) break;
            }
            myMap.Add(s[right]);
        }
        return Math.Max(res, myMap.Count);
    }
}
