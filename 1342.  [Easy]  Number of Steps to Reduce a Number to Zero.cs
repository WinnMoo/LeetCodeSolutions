public class Solution {
    public int NumberOfSteps (int num) {
        int copy = num;
        int steps = 0;
        while(copy > 0){
            if(copy % 2 == 0){
                copy = copy / 2;
                steps++;
            }else{
                copy = copy - 1;
                steps++;
            }
        }
        return steps;
    }
}