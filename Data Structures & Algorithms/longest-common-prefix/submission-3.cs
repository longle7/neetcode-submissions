public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        Array.Sort(strs);

        if (strs[0].Length == 0) return "";

        int curCharPos = 0;
        char curChar = strs[0][curCharPos];
        string resultStr = "";

        while (curCharPos < strs[0].Length)
        {
            foreach (var s in strs)
            {
                if (s[curCharPos] != curChar)
                {
                    return resultStr;
                }
            }
            resultStr += curChar;
            if (++curCharPos >= strs[0].Length) return resultStr;
            else curChar = strs[0][curCharPos];
        }
        return resultStr;

    }
}