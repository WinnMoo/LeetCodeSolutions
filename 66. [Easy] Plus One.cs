public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits[digits.Length-1] < 9){
            digits[digits.Length-1] = digits[digits.Length-1] + 1;
            return digits;
        }else{
            int iterator = digits.Length - 1;
            bool carryOver = true;
            while(carryOver){
                Console.WriteLine(iterator);
                digits[iterator] = digits[iterator] + 1;
                if(digits[iterator] == 10){
                    digits[iterator] = 0;
                }else{
                    carryOver = false;
                }
                iterator--;
                if(iterator == -1 && carryOver){
                    int[] newDigits = new int[digits.Length + 1];
                    digits.CopyTo(newDigits, 1);
                    digits = newDigits;
                    digits[0] = 1;
                    carryOver = false;
                }
            }
            return digits;
        }
    }
}