public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> uniqueNums = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(uniqueNums.Contains(nums[i])){
                return true;
            } else {
                uniqueNums.Add(nums[i]);
            }
        }
        return false;
    }
}