public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> numbers = new List<string>();
        for(int i = 1; i <= n; i++){
            if(i % 3 == 0 && i % 5 == 0){
                numbers.Add("FizzBuzz");
            }else if(i % 5 == 0){
                numbers.Add("Buzz");
            }else if(i % 3 == 0){
                numbers.Add("Fizz");
            }else{
                numbers.Add(i.ToString());
            }
        }
        return numbers;
    }
}