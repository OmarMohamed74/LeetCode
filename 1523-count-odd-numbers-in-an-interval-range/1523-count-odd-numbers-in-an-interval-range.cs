public class Solution {
    public int CountOdds(int low, int high) {
        
        if(low % 2 ==0 && high % 2 ==0){
            
         int result = (high-low)/2;
            
            return result;
        }else{
            
            return (high-low)/2 + 1;
        }
            
        
        
        
       
    }
}