public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !ValidPali(s[left])) left++;
            while (left < right && !ValidPali(s[right])) right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right])) return false;

            left++;
            right--;
        }

        return true;
    }

    private static bool ValidPali(char c)
    {
        return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9');
    }
}
