public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var window = new HashSet<char>();
        int l = 0;
        int res = 0;

        for (int r = 0; r < s.Length; r++)
        {
            while (window.Contains(s[r]))
            {
                window.Remove(s[l++]);
            }
            window.Add(s[r]);
            res = Math.Max(res, window.Count());
        }

        return res;
    }
}
