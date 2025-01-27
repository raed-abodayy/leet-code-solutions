public class Solution {
    public int MajorityElement(int[] nums) {
        int c1 = nums.Count();
        Dictionary<int, int> Mtest = new();
        foreach (var num in nums)
        {
            Mtest[num] = 0;
        }

        for (int i = 0; i < c1; i++)
        {
            Mtest[nums[i]] ++;
        }
        int max = 0;
        KeyValuePair<int, int> result = new (0, 0);;
        foreach (var m in Mtest)
        {
           if (m.Value > max)
           {
            max = m.Value;
            result = m;
           }
        }
        return result.Key;
    }
}