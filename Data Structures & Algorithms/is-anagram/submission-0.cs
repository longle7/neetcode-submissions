public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var myDict = new Dictionary<char, int>();

        // setting the dictionary
        foreach(char c in s)
        {
            if (myDict.ContainsKey(c))
            {
                myDict[c]++;
            }
            else
            {
                myDict[c] = 1;
            }
        }

        foreach (char c in t)
        {
            if (myDict.ContainsKey(c))
            {
                myDict[c]--;

                if (myDict[c] == 0) myDict.Remove(c);
            }
            else return false;
        }

        return myDict.Count == 0;

    }
}