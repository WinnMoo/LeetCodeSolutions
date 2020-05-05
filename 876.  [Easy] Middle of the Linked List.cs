/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode pointerToHead = head;
        int lengthOfLinkedList = 0;
        
        while(head != null){
            lengthOfLinkedList++;
            head = head.next;
        }
        int middleElement = lengthOfLinkedList/2;
        
        while(middleElement > 0){
            middleElement--;
            pointerToHead = pointerToHead.next;
        }
        return pointerToHead;
    }
}