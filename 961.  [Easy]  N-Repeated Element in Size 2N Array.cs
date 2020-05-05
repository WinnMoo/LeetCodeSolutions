public class Solution {
    public int RepeatedNTimes(int[] A) {
        Dictionary<int, int> numberOccurences = new Dictionary<int, int>();
        for(int i = 0; i < A.Length; i++){
            if(numberOccurences.ContainsKey(A[i])){
                int value = numberOccurences[A[i]];
                value++;
                numberOccurences[A[i]] = value;
            }else{
                numberOccurences.Add(A[i], 1);
            }
        }
        foreach (KeyValuePair<int, int> key in numberOccurences)
            if(numberOccurences[key.Key] == (A.Length/2)){
                return key.Key;
            }
        
        return 0;
    }
}