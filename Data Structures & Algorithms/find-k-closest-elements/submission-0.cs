public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0;
        int right = arr.Length - 1;

        while (right - left >= k)
        {
            if (Math.Abs(arr[left] - x) <= Math.Abs(arr[right] - x)) right--;
            else left++;
        }

        var result = new List<int>();
        for (int i = left; i <= right; i++)
        {
            result.Add(arr[i]);
        }

        return result;
    }
}