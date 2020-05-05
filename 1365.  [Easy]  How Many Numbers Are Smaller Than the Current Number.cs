public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] smaller = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            int numOfItemsSmallerThanI = 0;
            for(int j = 0; j < nums.Length; j++){
                if(nums[i] > nums[j]){
                    numOfItemsSmallerThanI++;
                }
            }
            smaller[i] = numOfItemsSmallerThanI;
        }
        return smaller;
    }
}