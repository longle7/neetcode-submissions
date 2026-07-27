
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        string res = "";

        int left = 0;
        int right = 0;

        bool blnLeft = true;

        while (left < word1.Length && right < word2.Length)
        {
            if (blnLeft)
            {
                res += word1[left];
                left++;
                blnLeft = false;
            }
            else
            {
                res += word2[right];
                right++;
                blnLeft = true;
            }
        }
        while (left < word1.Length)
        {
            res += word1[left];
            left++;
        }

        while (right < word2.Length)
        {
            res += word2[right];
            right++;
        }

        return res;
    }
}