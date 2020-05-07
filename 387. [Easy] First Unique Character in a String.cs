public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> uniqueChars = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            if(!uniqueChars.ContainsKey(s[i])){
                uniqueChars.Add(s[i], 1);
            }else{
                uniqueChars[s[i]] = uniqueChars[s[i]] + 1;
            }
        }
        int min = Int32.MaxValue;
        foreach(KeyValuePair<char, int> c in uniqueChars){
            if(c.Value == 1){
                int indexOfChar = s.IndexOf(c.Key.ToString(), 0, s.Length);
                if(indexOfChar < min){
                    min = indexOfChar;
                }
            }
        }
        if(min == Int32.MaxValue){
            return -1;
        }
        return min;
    }
}