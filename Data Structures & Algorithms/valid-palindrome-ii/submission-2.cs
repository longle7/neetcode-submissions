public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                return IsPali(s, left + 1, right) || IsPali(s, left, right - 1);
            }
        }

        return true;
    }

    private static bool IsPali(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right]) return false;

            left++;
            right--;
        }
        return true;
    }
}