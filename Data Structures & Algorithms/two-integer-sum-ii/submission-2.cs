
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int comp = target - numbers[i];

            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (numbers[mid] == comp) return new int[] { i+1, mid+1 };

                if (comp < numbers[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }
        return new int[] { -1, -1 };
    }
}
