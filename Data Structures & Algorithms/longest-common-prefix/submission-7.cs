public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        for (int c = 0; c < strs[0].Length; c++)
        {
            foreach (var s in strs)
            {
                if (c == s.Length || s[c] != strs[0][c]) return strs[0][..c];
            }
        }
        return strs[0];
    }
}