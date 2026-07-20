public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();


        for (int i = 0; i < strs.Length; i++)
        {
            var chars = strs[i].ToCharArray();
            Array.Sort(chars);
            var temp = new string(chars);
            if (!myDict.ContainsKey(temp))
            {
                // add the alphabetically sorted string to hashmap
                myDict.Add(temp, new List<string>() { strs[i] });
            }
            else
            {
                myDict[temp].Add(strs[i]);
            }
        }

        foreach (var d in myDict)
        {
            result.Add(d.Value);
        }

        return result;

    }
}