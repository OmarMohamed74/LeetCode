public class Solution {
    public int LargestPerimeter(int[] nums) {
        
// In a triangle, any two sides must add up to be greater than the third side.
        
        Array.Sort(nums);
        
        for (int i=nums.Length-3; i>=0;i--){
            if(nums[i]+nums[i+1]>nums[i+2]){
                return (nums[i]+nums[i+1]+nums[i+2]);
            }
        }
        return 0;
        
    }
}