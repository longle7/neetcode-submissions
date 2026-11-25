public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            Swap(s, left, right);
            left++;
            right--;
        }
    }

    private void Swap(char[] s, int a, int b)
    {
        var temp = s[a];
        s[a] = s[b];
        s[b] = temp;
    }
}