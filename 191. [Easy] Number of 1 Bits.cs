public class Solution {
    public int HammingWeight(uint n) {
        int numberOf1Bits = 0; //Accumulator to keep track of how many 1 bits we've encountered
        while(n > 0){ //While loop will only run while n is greater than 0
            bool result = (n & 1) == 1; // Perform bitwise and operation on the first bit of n, if it equals 1, then result gets set to true
            if(result){ //because we've performed an and operation (1 & 1 = 1), that means that the bit we're checking aginst is 1 thus increment numberOf1Bits
                numberOf1Bits++;
            }
            n = n >> 1; //Shift our n by 1 bit, this pads 0 to the left side of n (1111 -> 0111). Effectively divides by 2, eventually n will be less than 0 and end while loop.
        }
        return numberOf1Bits;
    }
}