public class Solution {
    public int MinPartitions(string n) {
         char[] partitions = n.ToCharArray();
    int max = 0;
    int temp = 0;

    for(int i = 0; i < partitions.Length; i++)
    {
        temp = partitions[i] - '0';   // asciicode
        if (temp > max)
            max = temp;
        
    }
        return max;
    }
}