public class Solution {
    public int HammingWeight(uint n) {
        
       
         // The base of the return value, which must be 2, 8, 10, or 16.

        
        var result = Convert.ToString(n,2); 
        
        var counter = result.Count(c=>c=='1');
        
        return counter;
        
        
        
    }
}