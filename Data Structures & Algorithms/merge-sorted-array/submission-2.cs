public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = nums1.Length - 1;
        int left = m - 1;
        int right = n - 1;

        while (right >= 0)
        {
            nums1[i--] = (left >= 0 && nums1[left] > nums2[right]) ? nums1[left--] : nums2[right--];
        }
    }
}