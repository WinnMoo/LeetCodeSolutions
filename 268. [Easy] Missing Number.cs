public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        n = n*(n+1)/2;
        for(int i = 0; i < nums.Length; i++){
            n = n - nums[i];
        }
        return n;
    }
}