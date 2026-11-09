public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var myDict = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            var charCount = new int[26];

            foreach (var c in s)
            {
                charCount[c - 'a']++;
            }

            string key = String.Join(",", charCount);

            if (!myDict.ContainsKey(key)) myDict[key] = new List<string>();

            myDict[key].Add(s);
        }

        return myDict.Values.ToList();
    }
}
