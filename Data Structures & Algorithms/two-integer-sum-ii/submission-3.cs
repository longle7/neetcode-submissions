public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int curSum = numbers[left] + numbers[right];
            if (curSum == target) return new int[] { left + 1, right + 1 };

            if (curSum < target) left++;
            else right--;
        }

        return new int[] { -1, -1 };
    }
}
