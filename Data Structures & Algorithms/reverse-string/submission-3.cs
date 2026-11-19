public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            Swap(s, left++, right--);

        }
    }

    private static void Swap(char[] s, int i, int j)
    {
        char temp = s[i];

        s[i] = s[j];
        s[j] = temp;
    }
}