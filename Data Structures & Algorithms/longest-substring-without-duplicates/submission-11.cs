public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var window = new HashSet<char>();
        int left = 0;
        int res = 0;

        foreach (var c in s)
        {
            while (window.Contains(c))
            {
                window.Remove(s[left++]);
            }
            window.Add(c);

            res = Math.Max(res, window.Count());
        }

        return res;
    }
}
