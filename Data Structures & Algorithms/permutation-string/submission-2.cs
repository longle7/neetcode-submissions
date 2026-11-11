public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;
        int[] need = new int[26];
        int[] have = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            need[s1[i] - 'a']++;
            have[s2[i] - 'a']++;
        }

        if (Same(need,have)) return true;

        for (int right = s1.Length; right < s2.Length; right++)
        {
            have[s2[right] - 'a']++;
            have[s2[right - s1.Length] - 'a']--;
            if (Same(have, need)) return true;
        }
        return false;
    }

    private static bool Same(int[] a, int[] b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
}
