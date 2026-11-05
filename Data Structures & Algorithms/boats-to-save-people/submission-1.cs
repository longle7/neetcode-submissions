public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int left = 0;
        int right = people.Length - 1;
        int count = 0;

        Array.Sort(people);

        while (left <= right)
        {
            int curSum = people[left] + people[right];
            if (curSum <= limit)
            {
                left++;
            }
            count++;
            right--;
        }

        return count;
    }
}