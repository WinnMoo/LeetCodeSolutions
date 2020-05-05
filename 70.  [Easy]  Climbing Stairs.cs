public class Solution {
    public int ClimbStairs(int n) {
        int step = 1;
        int a = 0;
        int b = 1;
        while(step <= n){
            int temp = a + b;
            a = b;
            b = temp;
            step++;
        }
        return b;
    }
}
