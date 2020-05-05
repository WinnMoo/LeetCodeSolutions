/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode head = null;
        ListNode pointer = new ListNode();
        head = pointer;
        if(l1 == null && l2 == null){
            return null;
        }
        while(l1 != null || l2!= null){
            if(l1 != null && l2 != null){
                if(l1.val < l2.val){
                    pointer.val = l1.val;
                    l1 = l1.next;
                } else if (l1.val > l2.val){
                    pointer.val = l2.val;
                    l2 = l2.next;
                } else {
                    pointer.val = l1.val;
                    pointer.next = new ListNode();
                    pointer = pointer.next;
                    pointer.val = l2.val;

                    l1 = l1.next;
                    l2 = l2.next;
                }

                if(l1 != null || l2 != null){
                    pointer.next = new ListNode();
                    pointer = pointer.next;
                }
            } else if(l1 == null){
                pointer.val = l2.val;
                if(l2.next != null){
                    pointer.next = new ListNode();
                    pointer = pointer.next;
                }
                l2 = l2.next;
                
            } else if(l2 == null){
                pointer.val = l1.val;
                if(l1.next != null){
                    pointer.next = new ListNode();
                    pointer = pointer.next;
                }
                l1 = l1.next;
            }
            
        }
        return head;
    }
}