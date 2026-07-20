public class Solution
{
    public bool IsPalindrome(string s)
    {
        var cleaned = new string(s
            .Where(char.IsAsciiLetterOrDigit)
            .Select(char.ToLower)
            .ToArray());

        int left = 0;
        int right = cleaned.Length-1;

        while (left < right)
        {
            if (cleaned[left] != cleaned[right]) return false;

            left++;
            right--;
        }

        return true;
    }
}
