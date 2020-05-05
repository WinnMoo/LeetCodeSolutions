public class Solution {
    public bool BackspaceCompare(string S, string T) {
        
        List<char> sArray = new List<char>();
        List<char> tArray = new List<char>();
        for(int i = 0; i < S.Length; i++){
            if(S[i] == '#'){
                if(sArray.Count > 0){
                    sArray.RemoveAt(sArray.Count - 1);
                }
            }else{
                sArray.Add(S[i]);
            }
        }
        
        for(int j = 0; j < T.Length; j++){
            if(T[j] == '#'){
                if(tArray.Count > 0){
                    tArray.RemoveAt(tArray.Count - 1);
                }
            }else{
                tArray.Add(T[j]);
            }
        }
        
        if(sArray.Count != tArray.Count){
            return false;
        }
        for(int z = 0; z < sArray.Count; z++){
            if(sArray[z] != tArray[z]){
                return false;
            }
        }
        return true;
    }
}