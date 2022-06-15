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
    public ListNode MiddleNode(ListNode head) {
       ArrayList headList = new ArrayList();
 
            while (head != null)
            {
                headList.Add(head);
                head = head.next;
            }

            var midleNode = (headList.Count / 2);

            return ((ListNode)headList[midleNode]);  
    }
}