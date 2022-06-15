/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */


public class Solution {
   
    public bool IsPalindrome(ListNode head) {
        
        ArrayList headList = new ArrayList();
        ArrayList reversedList = new ArrayList();
        
        while(head!=null)
        {
            var headValue = head.val;
            headList.Add(headValue);
            reversedList.Add(headValue);
            head=head.next;
            
        };
        
        reversedList.Reverse();
        
        
        
        for (int i =0; i<headList.Count;i++){
            
            if((int)headList[i] != (int)reversedList[i])
              return false;  
        }
         
        return true;
        
    }
}