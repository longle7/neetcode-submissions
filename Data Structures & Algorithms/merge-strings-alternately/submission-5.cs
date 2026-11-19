public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int left = 0;
        int right = 0;

        var res = new StringBuilder();

        while (left < word1.Length && right < word2.Length) res.Append(word1[left++] + "" + word2[right++]);

        while (left < word1.Length) res.Append(word1[left++]);
        while (right < word2.Length) res.Append(word2[right++]);

        return res.ToString();
    }
}