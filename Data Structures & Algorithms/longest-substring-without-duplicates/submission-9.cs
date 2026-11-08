public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var window = new HashSet<char>();
        int res = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (window.Contains(s[right]))
            {
                window.Remove(s[left++]);
            }
            window.Add(s[right]);
            res = Math.Max(res, window.Count());
        }
        return res;
    }
}
