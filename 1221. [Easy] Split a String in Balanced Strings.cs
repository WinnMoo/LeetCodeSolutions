public class Solution {
    public int BalancedStringSplit(string s) {
        int count = 0;
        int sum = 0; //left = + 1; right = - 1
        for(int i = 0; i < s.Length; i++){
            if(s[i].ToString() == "L"){
                sum++;
            }else{
                sum--;
            }
            if(sum == 0){
                count++;
            }
        }
        return count;
    }
}