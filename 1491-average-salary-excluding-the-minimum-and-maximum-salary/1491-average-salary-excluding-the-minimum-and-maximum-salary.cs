public class Solution {
    public double Average(int[] salary) {
        
       Array.Sort(salary);
    double[] remainingArray = new double[salary.Length];

    for (int i = 1; i < salary.Length-1; i++)
    {
        remainingArray[i - 1] = salary[i];
    }

    double averageSalary = remainingArray.Sum();
    double averageSalaryLength = (remainingArray.Length) - 2;
    return averageSalary / averageSalaryLength;
    }
}