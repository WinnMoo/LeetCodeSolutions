public class Solution {
    public int FindNumbers(int[] nums) {
        int evenDigits = 0;
        for(int i = 0; i < nums.Length; i++){
            int numberToCheck = nums[i];
            int numOfDigits = 0;
            while(numberToCheck > 0){
                numberToCheck = numberToCheck/10;
                numOfDigits++;
            }
            if(numOfDigits % 2 == 0){
                evenDigits++;
            }
        }
        return evenDigits;
    }
}