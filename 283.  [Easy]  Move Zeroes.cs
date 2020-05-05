public class Solution {
    public void MoveZeroes(int[] nums) {
        int pointer = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != 0){
                if(i != pointer){
                    nums[pointer] = nums[i];
                    nums[i] = 0;
                }
                pointer++;
            }
        }
    }
}