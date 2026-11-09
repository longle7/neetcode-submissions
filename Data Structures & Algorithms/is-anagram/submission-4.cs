public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var myDict = new Dictionary<char, int>();

        foreach (var c in s)
        {
            myDict[c] = myDict.GetValueOrDefault(c) + 1;
        }

        foreach (var c in t)
        {
            if ((myDict.GetValueOrDefault(c)) == 0) return false;
            myDict[c]--; 
        }

        return true;
    }
}
