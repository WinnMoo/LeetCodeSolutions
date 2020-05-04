public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = Int32.MinValue;
        foreach(int c in candies){
           if(c > max){
               max = c;
           }
        }
        List<bool> listOfGreatestCandies = new List<bool>();
        for(int i = 0; i < candies.Length; i++){
            if(candies[i] + extraCandies >= max){
                listOfGreatestCandies.Add(true);
            }else{
                listOfGreatestCandies.Add(false);
            }
        }
        return listOfGreatestCandies;
    }
}