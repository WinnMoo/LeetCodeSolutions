public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyOfNums = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(!frequencyOfNums.ContainsKey(nums[i])){
                frequencyOfNums.Add(nums[i], 1);
            }else{
                frequencyOfNums[nums[i]] = frequencyOfNums[nums[i]] + 1;
            }
        }
        List<int> frequencies = new List<int>();
        foreach(var freq in frequencyOfNums){
            frequencies.Add(freq.Value);
        }
        
        frequencies.Sort();
        frequencies.RemoveRange(0, frequencies.Count - k);
        List<int> TopKFrequent = new List<int>();
        foreach(var frequ in  frequencyOfNums){
            if(frequencies.Exists(element => element == frequ.Value)){
                TopKFrequent.Add(frequ.Key);
            }
        }
        return TopKFrequent.ToArray();
    }
}