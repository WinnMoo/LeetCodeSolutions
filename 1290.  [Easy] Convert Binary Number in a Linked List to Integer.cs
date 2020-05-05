/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int GetDecimalValue(ListNode head) {
        int sum = 0;
        while(head != null){
            sum = sum*2 + head.val;
            head = head.next;
        }
        return sum;
    }
}