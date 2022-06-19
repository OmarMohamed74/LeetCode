public class Solution {
    public int MostWordsFound(string[] sentences) {
     int max = 0;
    for(int i = 0; i < sentences.Length; i++)
    { 
        string[] words = sentences[i].Split(' ');
        //if(words.Length > max)
        //    max = words.Length;

        max = Math.Max(max, words.Length);
    }
    return max;
    }
}