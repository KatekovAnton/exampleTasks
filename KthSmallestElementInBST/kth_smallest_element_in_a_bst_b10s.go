package main

import (
	"fmt"
)

/*
Input: root = [3,1,4,null,2], k = 1
   3
  / \
 1   4
  \
   2
Output: 1
*/

func main() {
	t := &TreeNode{3, &TreeNode{1, nil, &TreeNode{2, nil, nil}}, &TreeNode{4, nil, nil}}

	//[5,3,6,2,4,null,null,1]
	//t := &TreeNode{5, &TreeNode{3, &TreeNode{2, &TreeNode{1, nil, nil}, nil}, &TreeNode{4, nil, nil}}, &TreeNode{6, nil, nil}}

	fmt.Println(kthSmallest(t, 4))
}

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func kthSmallest(root *TreeNode, k int) int {
	s := []*TreeNode{}
	n := root
	for {
		if n.Left != nil {
			s = append(s, n)
			n = n.Left
			continue
		}
		k--
		if k == 0 {
			return n.Val
		}

		if n.Right != nil {
			s = append(s, n)
			n = n.Right
			continue
		}

		for {
			pre := n.Val
			n = s[len(s)-1]
			s = s[:len(s)-1]

			// come from left, means:
			// a node is the most left which has no more lefts
			if pre < n.Val {
				k--
				if k == 0 {
					return n.Val
				}
				if n.Right != nil {
					n = n.Right
					break
				}
			}
		}
	}
}
// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
// https://play.golang.org/p/5Qhtwm_bKR8
