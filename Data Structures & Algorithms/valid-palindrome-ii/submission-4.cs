public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            if (s[l] != s[r])
            {
                return IsPali(s, l + 1, r) || IsPali(s, l, r - 1);
            }
            l++;
            r--;
        }

        return true;

    }

    private static bool IsPali(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l] != s[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}