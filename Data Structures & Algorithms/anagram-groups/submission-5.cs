public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            string key = GetKey(strs[i]);
            if (!myDict.ContainsKey(key))
            {
                // add the alphabetically sorted string to hashmap
                myDict.Add(key, new List<string>() { strs[i] });
            }
            else
            {
                myDict[key].Add(strs[i]);
            }
        }

        foreach (var d in myDict)
        {
            result.Add(d.Value);
        }

        return result;
    }

    // gets the string in alphabetical order
    private static string GetKey(string s)
    {
        Span<int> counts = stackalloc int[26];

        foreach (char c in s)
        {
            counts[c - 'a']++;
        }

        var sb = new StringBuilder(s.Length + 26);

        for (int i = 0; i < 26; i++)
        {
            if (counts[i] > 0)
            {
                sb.Append((char)('a' + i)).Append(counts[i]);
            }
        }

        return sb.ToString();
    }
}
