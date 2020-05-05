public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        int[] decompressedList = new int[0];
        for(int i = 0; i < nums.Length; i = i + 2){
            int[] uncompressedList = new int[nums[i]];
            for(int j = 0; j < uncompressedList.Length; j++){
                uncompressedList[j] = nums[i + 1];
            }
            int[] tempList = new int[decompressedList.Length + uncompressedList.Length];
            decompressedList.CopyTo(tempList, 0);
            uncompressedList.CopyTo(tempList, decompressedList.Length);
            decompressedList = tempList;
        }
        return decompressedList;
    }
}