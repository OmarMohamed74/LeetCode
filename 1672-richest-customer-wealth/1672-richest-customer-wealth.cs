public class Solution {
    public int MaximumWealth(int[][] accounts) {
    int[] maximumWealth = new int[accounts.Length];
    int sum=0;
    int max=0;

    for(int row = 0; row < accounts.Length; row++)
    {
        sum = 0;
        for(var colum = 0; colum < accounts[row].Length; colum++)
        {
           sum+=accounts[row][colum];  
        }

        if(max < sum)
            max = sum;
    }

   return max;
    }
}