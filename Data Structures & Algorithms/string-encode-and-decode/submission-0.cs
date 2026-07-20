
public class Solution
{
    public string Encode(IList<string> strs)
    {
        string strEncoded = "";
        foreach (var s in strs)
        {
            int length = s.Length;
            strEncoded += length + "#" + s;
        }
        return strEncoded;
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#') j++;

            int len = int.Parse(s.Substring(i, j - i));
            string str = s.Substring(j + 1, len);
            result.Add(str);

            i = j + len + 1;
        }
        return result;
    }
}
