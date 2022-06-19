public class Solution {
    public int MinPartitions(string n) {
        
    int max = 0;
   for (int i = 0; i < n.Length; i++)
     max = Math.Max(n[i] - '0' , max);
        
        return max;
    }
}