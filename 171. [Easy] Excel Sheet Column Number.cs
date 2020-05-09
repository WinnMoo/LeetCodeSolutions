public class Solution {
    public int TitleToNumber(string s) {
        int place = 0;
        int sum = 0;
        for(int i = s.Length - 1; i >= 0; i--){
            sum = sum + ((int)s[i] - 64) * (int)Math.Pow(26, place);
            place++;
        }
        return sum;
    }
}