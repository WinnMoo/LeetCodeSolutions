//This is a brute force solution, needs to be optimized
public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length]; //Result array will be the same size as the first array
        Dictionary<int, int> elementIndexPair = new Dictionary<int, int>(); //We're mapping the element to it's index
        for(int i = 0; i < nums2.Length; i++){
            elementIndexPair.Add(nums2[i], i);
        }
        for(int j = 0; j < nums1.Length; j++){ //Loop through the first array
            int indexToCheck = elementIndexPair[nums1[j]] + 1; //We know where to start searching in the second array through our Dictionary because we've mapped the element to it's index. Add 1 because we don't need to search the index that the element is orinally at.
            if(nums2.Length == indexToCheck){ //If the index to start our search at is greater than the length of the 2nd array, then we know there's no greater number than the one we're currently searching against
                result[j] = -1;
            }else{
                bool foundGreaterValue = false; //This flag is used to figure out if we've found an element that is greater than what we're checking against
                for(int k = indexToCheck; k < nums2.Length; k++){ //Start our search with the index we've found through our dictionary
                    if(nums1[j] < nums2[k]){
                        result[j] = nums2[k];
                        foundGreaterValue = true; //Set our flag to true because we've found a greater element
                        k = nums2.Length; //Break out of the for loop 
                    }
                }
                if(!foundGreaterValue){ //If we haven't found any element greater than the one we're currently checking against, then set to -1
                    result[j] = -1;
                }
            }
        }
        return result;
    }
}