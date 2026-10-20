public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var myDict = new Dictionary<string, List<string>>();

        // loop through each string in strs
        foreach (var s in strs)
        {
            int[] count = new int[26];

            // loop through each char in string
            foreach (char c in s)
            {
                count[c - 'a']++;
            }

            //make a touple out of the count array
            string key = string.Join(",", count);
            if (!myDict.ContainsKey(key)) myDict[key] = new List<string>();

            // add the touple as the key and the original string to the associate with the key
            myDict[key].Add(s);
        }
        return myDict.Values.ToList<List<string>>();
    }
}
