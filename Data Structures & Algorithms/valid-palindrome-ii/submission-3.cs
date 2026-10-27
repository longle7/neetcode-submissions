public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            if (s[i] != s[j])
            {
                return (IsPalidrome(s, i + 1, j) || IsPalidrome(s, i, j - 1));
            }
            i++;
            j--;
        }

        return true;
    }

    private static bool IsPalidrome(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j]) return false;
            i++;
            j--;
        }
        return true;
    }
}