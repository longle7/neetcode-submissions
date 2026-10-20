public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string res = "";

        // i is index of char we are on
        for (int i = 0; i < strs[0].Length; i++)
        {
            // looping through all the words in strs
            foreach (var s in strs)
            {
                // if the index we are on is out of bounds or the cur char is not equal to the char in first element
                if (i == s.Length || s[i] != strs[0][i]) return res;
            }
            res += strs[0][i];
        }
        return res;
    }
}