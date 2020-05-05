public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(m == 0){
            for(int z = 0; z <= nums2.Length - 1; z++){
                nums1[z] = nums2[z];
            }
        }

            
        int i = m - 1;
        int j = n - 1;
        int pointer = nums1.Length - 1;
        while(i >= 0 && j >= 0){
            if(nums2[j] > nums1[i]){
                nums1[pointer] = nums2[j];
                j--;
            }else{
                nums1[pointer] = nums1[i];
                i--;
            }
            pointer--;
            if(pointer >= 0 && i < 0){
                for(int index = pointer; index >= 0; index--){
                    nums1[index] = nums2[j];
                    j--;
                }
            }
        }
    }
}