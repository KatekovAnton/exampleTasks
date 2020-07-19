/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null) {
            return null;
        }
        ListNode a = headA;
        ListNode b = headB;
        ListNode intersect = null;
        while (a != b) {
            a = a.next;
            b = b.next;
            if (a == b) {
                return a;
            }
            if (a == null) {
                a = headB;
            }
            if (b == null) {
                b = headA;
            }
        }
        
        return a;
    }
}
