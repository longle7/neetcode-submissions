public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int res = 0;
        int left = 0;
        var seen = new HashSet<char>();

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            while (seen.Contains(c))
            {
                seen.Remove(s[left]);
                left++;
            }

            seen.Add(c);
            res = Math.Max(res, right - left + 1);
        }

        return res;
    }
}
