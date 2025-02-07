public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int x = digits.Length - 1; x >= 0; x--) 
        {
            if (digits[x] < 9)
             {
                digits[x]++;
                return digits;
            }
            digits[x] = 0;
        }
    
        int[] newarr = new int[digits.Length + 1];
        newarr[0] = 1;
        return newarr;
    }
}
