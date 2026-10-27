public class Solution
{
    public void ReverseString(char[] s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            Swap(s, i, j);
            i++;
            j--;
        }

    }

    private static void Swap(char[] s, int i, int j)
    {
        char temp = s[i];
        s[i] = s[j];
        s[j] = temp;
    }
}