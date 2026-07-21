public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        int[] s1Count = new int[26];
        int[] windowCount = new int[26];

        int left = 0;

        // putting all the values from the strings into their respective arrays
        for (int i = 0; i < s1.Length; i++)
        {
            s1Count[s1[i] - 'a']++;
            windowCount[s2[i] - 'a']++;
        }

        if (s1Count.SequenceEqual(windowCount)) return true;
        

        for (int i = s1.Length; i < s2.Length; i++)
        {
            windowCount[s2[i] - 'a']++;
            windowCount[s2[i - s1.Length] - 'a']--;
            if (s1Count.SequenceEqual(windowCount)) return true;
        }
        return false;
    }
}
