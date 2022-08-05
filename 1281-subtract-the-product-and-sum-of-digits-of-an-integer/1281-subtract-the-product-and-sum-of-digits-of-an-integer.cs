public class Solution {
    public int SubtractProductAndSum(int n) {
        
        string convertToString = Convert.ToString(n);
        
        int product = 1;
        int sum = 0;
        
        
        for(int i=0;i<convertToString.Length;i++){
            
            product *=convertToString[i] - '0';
            sum += convertToString[i] - '0';
        }
        
        return  product - sum;
        
    }
}