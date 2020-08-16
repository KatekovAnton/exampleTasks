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
public bool IsPalindrome(ListNode head) 
{
	ListNode dummy = new ListNode(0, head);
	ListNode slow = dummy;
	ListNode fast = dummy;

	while(fast != null && fast.next != null)
	{
		slow = slow.next;
		fast = fast.next.next;
	}

	var mid = slow;

	var reverseHead = reverseList(slow.next);
	mid.next = null;

	var current = head;
	var last = reverseHead;        

	bool isPalindrome = true;
	while(last != null)
	{           
		if(current.val != last.val)
		{
			isPalindrome = false;
			break;
		}

		last = last.next;
		current = current.next;
	}

	mid.next = reverseList(reverseHead);

	return isPalindrome;
}

private ListNode reverseList(ListNode head)
{
	ListNode previous = null;
	ListNode current = head;
	ListNode next;

	while(current != null)
	{
		next = current.next;
		current.next = previous;
		previous = current;
		current = next;
	}

	return previous;
}
}
