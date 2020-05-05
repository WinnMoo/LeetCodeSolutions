public class Solution {
    public int MajorityElement(int[] nums) {
        int numOfOccurrences = nums.Length / 2;
        var occurences = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(occurences.ContainsKey(nums[i])){
                occurences[nums[i]]++;
            }else{
                occurences.Add(nums[i], 1);
            }
        }
        int max = occurences[nums[0]];
        int maxKey = nums[0];
        foreach(var entry in occurences){
            if(entry.Value > max){
                maxKey = entry.Key;
                max = entry.Value;
            }
        }
    return maxKey;
    }
}