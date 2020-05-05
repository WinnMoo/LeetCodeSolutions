public class Solution {
    public bool IsAnagram(string s, string t) {
        if(String.IsNullOrEmpty(s) || String.IsNullOrEmpty(t)){
            if(s.Equals(t)){
                return true;
            }else {
                return false;
            }
        }else if(s.Length > t.Length || s.Length < t.Length){
            return false;
        }else{
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++){
                if(letters.ContainsKey(s[i])){
                    letters[s[i]]++;
                }else{
                    letters.Add(s[i], 1);
                }
            }

            for(int j = 0; j < t.Length; j++){
                if(letters.ContainsKey(t[j])){
                    letters[t[j]]--;
                }else{
                    return false;
                }
            }
            foreach(var letter in letters){
                if(letter.Value < 0 || letter.Value > 0){
                    return false;
                }
            }
            return true;
        }
    }
}