public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int left = 0;
        int right = 0;

        string res = "";

        while (left < word1.Length && right < word2.Length) res += word1[left++] + "" + word2[right++];

        while (left < word1.Length) res += word1[left++];
        while (right < word2.Length) res += word2[right++];

        return res;
    }
}