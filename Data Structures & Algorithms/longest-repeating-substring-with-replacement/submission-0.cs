public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int[] count = new int[26];
        int left = 0;
        int maxFreq = 0;
        int result = 0;

        for (int right = 0; right < s.Length; right ++)
        {
            count[s[right] - 'A']++;
            maxFreq = Math.Max(maxFreq, count[s[right] - 'A']);

            // While chars in current window size that are not most freq
            // greater than k

            // decrease left char count
            // move the left boundry up one
            while ((right - left + 1) - maxFreq > k)
            {
                count[s[left] - 'A']--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}
