public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        string[] sorted = new string[strs.Length];
        Array.Copy(strs, sorted, strs.Length);
        Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();

        // sort each element into alphabetical order
        for (int i = 0; i < sorted.Length; i++)
        {
            var chars = sorted[i].ToCharArray();
            Array.Sort(chars);
            sorted[i] = new string(chars);
        }

        for (int i = 0; i < sorted.Length; i++)
        {
            if (!myDict.ContainsKey(sorted[i]))
            {
                // add the alphabetically sorted string to hashmap
                myDict.Add(sorted[i], new List<string>() { strs[i] });
            }
            else
            {
                myDict[sorted[i]].Add(strs[i]);
            }
        }

        foreach (var d in myDict)
        {
            result.Add(d.Value);
        }

        return result;

    }
}