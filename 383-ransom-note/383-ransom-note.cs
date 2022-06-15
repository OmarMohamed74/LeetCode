public class Solution {
     public bool CanConstruct(string ransomNote, string magazine)
        {
           List<char> arrTwo = ransomNote.ToList();

            List<char> arrOne = magazine.ToList();
           
                    for (int i = 0; i < arrOne.Count; i++)
                    {
                        if (arrTwo.Contains(arrOne[i]))
                            arrTwo.Remove(arrOne[i]);
                           
                    }

                    if (arrTwo.Count == 0)
                        return true;

            return false;
        }
}