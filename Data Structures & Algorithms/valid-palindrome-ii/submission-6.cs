public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right]) return PaliCheck(s, left + 1, right) || PaliCheck(s, left, right - 1);

            left++;
            right--;
        }

        return true;
    }

    private static bool PaliCheck(string s, int left, int right)
    {
        while(left < right)
        {
            if (s[left] != s[right]) return false;

            left++;
            right--;
        }

        return true;
    }
}