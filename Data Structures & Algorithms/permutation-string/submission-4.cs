public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        var have = new int[26];
        var need = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            have[s2[i] - 'a']++;
            need[s1[i] - 'a']++;
        }

        for (int i = s1.Length; i < s2.Length; i++)
        {
            if (Same(have, need)) return true;

            have[s2[i - s1.Length] - 'a']--;
            have[s2[i] - 'a']++; 
        }

        return Same(have, need);
        
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
