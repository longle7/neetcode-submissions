public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var myDict = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            int[] letters = new int[26];
            foreach (var c in s)
            {
                letters[c - 'a']++;
            }

            string key = string.Join(",", letters);
            if (!myDict.ContainsKey(key)) myDict[key] = new List<string>();

            myDict[key].Add(s);
        }

        return myDict.Values.ToList();
    }
}
