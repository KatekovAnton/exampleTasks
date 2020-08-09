/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> visited = new HashSet<ListNode>();
        bool hasCycle = false;
        while (head != null && !hasCycle) {
            if (visited.Contains(head)) {
                hasCycle = true;
            } else {
                visited.Add(head);
                head = head.next;
            }
        }
        
        return hasCycle;
    }
}
