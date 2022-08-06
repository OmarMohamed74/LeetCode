public class Solution {
    public int LargestPerimeter(int[] nums) {
        
// In a triangle, any two sides must add up to be greater than the third side.
        
        Array.Sort(nums);
        
        for (int i=nums.Length -3; i>=0;i--){
            var numbersChecked =nums[i]+nums[i+1]>nums[i+2];
            
            if(numbersChecked){
                return (nums[i]+nums[i+1]+nums[i+2]);
            }
        }
        return 0;
        
    }
}