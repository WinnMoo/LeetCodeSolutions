public class Solution {
    public int CalPoints(string[] ops) {
        int sum = 0;
        List<int> operations = new List<int>(); //A list of operations that are performed
        for(int i = 0; i < ops.Length; i++){
            if(ops[i] == "C"){ //Not an operation, so not added to the operations list. Invalidates latest operation, so removes from the operations list
                int lastInt = operations[operations.Count - 1];
                if(lastInt < 0){
                    sum = sum + (lastInt * -1);
                }else{
                    sum = sum - lastInt;
                }
                operations.RemoveAt(operations.Count - 1);
            } else if(ops[i] == "D"){
                int lastInt = operations[operations.Count - 1];
                lastInt = lastInt * 2;
                sum = sum + lastInt;
                operations.Add(lastInt);
            } else if(ops[i] == "+"){
                int penultimateRoundPoints = operations[operations.Count - 2];
                int beforeCurrentRoundPoints = operations[operations.Count - 1];
                int total = penultimateRoundPoints + beforeCurrentRoundPoints;
                sum = sum + total;
                operations.Add(total);
            }else{
                sum = sum + Convert.ToInt32(ops[i]);
                operations.Add(Convert.ToInt32(ops[i]));
            }
        }
        return sum;
    }
}