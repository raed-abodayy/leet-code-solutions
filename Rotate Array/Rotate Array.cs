using System;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int arrlen = nums.Length;
        k%=arrlen;
        Reverse(nums, 0, arrlen - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, arrlen - 1);
    }

     void Reverse(int[] nums, int front, int back)
    {
        while (front < back)
        {
            (nums[front], nums[back]) = (nums[back], nums[front]);
            front++;
            back--;
        }
    }
}
