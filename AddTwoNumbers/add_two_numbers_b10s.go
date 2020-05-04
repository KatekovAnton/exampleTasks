// https://leetcode.com/problems/add-two-numbers/
package main

import (
	"fmt"
)

type ListNode struct {
	Val  int
	Next *ListNode
}

func main() {
	l1 := ListNode{Val: 1}

	l2 := ListNode{Val: 9}
	l2.Next = &ListNode{Val: 9}

	res := addTwoNumbers(&l1, &l2)
	for {
		if res == nil {
			break
		}
		fmt.Println(res.Val)
		res = res.Next
	}
}

func addTwoNumbers(l1 *ListNode, l2 *ListNode) *ListNode {
	el1 := *l1
	el2 := *l2
	resL := &ListNode{}
	root := resL
	car := 0
	for {
		res := el1.Val + el2.Val + car
		resL.Val = res % 10
		car = int(res / 10)
		if el1.Next == nil && el2.Next == nil && car == 0 {
			break
		}
		resL.Next = &ListNode{}
		resL = resL.Next

		if el1.Next != nil {
			el1 = *el1.Next
		} else {
			el1.Val = 0
		}
		if el2.Next != nil {
			el2 = *el2.Next
		} else {
			el2.Val = 0
		}
	}
	return root
}
