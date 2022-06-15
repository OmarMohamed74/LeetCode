public class Solution {
    public int NumberOfSteps(int num) {
        int counter=0;

        while (num != 0)
        {
            if(num % 2 != 0)
            {
                num = num-1;
                counter++;
            }
            else
            {
                num = num / 2;
                counter++;
            }
        }
        return counter;
    }
}