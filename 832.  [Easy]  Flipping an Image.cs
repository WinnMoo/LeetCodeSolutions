public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        for(int i = 0; i < A.Length; i++){
            for(int j = 0; j < A[i].Length/2; j++){
                int temp = A[i][j];
                A[i][j] = A[i][A[i].Length - 1 - j];
                A[i][A[i].Length - 1 - j] = temp;
            }
        }
        for(int i = 0; i < A.Length; i++){
            for(int j = 0; j < A[i].Length; j++){
                if(A[i][j] == 0){
                    A[i][j] = 1;
                }else{
                    A[i][j] = 0;
                }
            }
        }
        return A;
    }
}