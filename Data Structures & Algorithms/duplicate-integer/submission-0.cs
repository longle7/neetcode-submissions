public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var myMap = new HashSet<int>();

        foreach (var n in nums)
        {
            if (!myMap.Contains(n)) myMap.Add(n);
            else return true;
        }
        return false;
    }
}