public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var myDict = new Dictionary<char, int>();

        foreach (char c in s)
        {
            myDict[c] = myDict.GetValueOrDefault(c) + 1;
        }

        foreach (char c in t)
        {
            if (!myDict.TryGetValue(c, out int value) || value == 0) return false;

            myDict[c]--;
        }

        return true;
    }
}
