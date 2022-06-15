public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        
        int counter = 0;
        Dictionary<int, int> matIndexies = new Dictionary<int, int>();

        int[] weakest = new int[k];

        for (int i = 0; i < mat.Length; i++)
        {
            counter = 0;
            for(int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1)
                {
                    counter++; 
                }
            }

            matIndexies.Add(i, counter);
        }

        var sortedDict = (from obj in matIndexies orderby obj.Value ascending select obj.Key).ToArray();

        for(int i = 0; i < k; i++)
        {
            weakest[i]=sortedDict[i];
        }

        return weakest;
    }
}