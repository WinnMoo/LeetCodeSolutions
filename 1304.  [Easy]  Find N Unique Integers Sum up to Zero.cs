public class Solution {
    public int[] SumZero(int n) {
        int[] array = new int[n];
        if(n == 1){
            array[0] = 0;
            return array;
        }
        if(n % 2 == 1){
            array[0] = 0;
            for(int i = 1; i < n; i = i + 2){
                array[i] = i;
                array[i+1] = i * -1;
            }
        } else{
            array[0] = 1;
            array[1] = -1;
            for(int i = 2; i < n; i = i + 2){
                array[i] = i;
                array[i+1] = i * -1;
            }
        }
        return array;
    }
}