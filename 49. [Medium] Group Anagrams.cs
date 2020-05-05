public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>(); 
        for(int i = 0; i < strs.Length; i++){
            char[] wordInCharForm = strs[i].ToCharArray();
            Array.Sort(wordInCharForm);
            string sortedString = new string(wordInCharForm);
            if(!dict.ContainsKey(sortedString)){
                dict.Add(sortedString, new List<string>());
            }
            dict[sortedString].Add(strs[i]);
        }
        return new List<IList<string>>(dict.Values);
    }
}