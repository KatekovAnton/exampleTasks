package main

import (
	"fmt"
)

func main() {
	node := &TreeNode{1, &TreeNode{2, nil, nil},  &TreeNode{3, nil, nil}}
	
	fmt.Println(deepestLeavesSum(node))
}

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

var (
	sum, maxDeepDived int
)

func deepestLeavesSum(root *TreeNode) int {
	helper(0, root)
	return sum
}

func helper(currentDeep int, node *TreeNode) {
	if currentDeep == maxDeepDived {
		sum += node.Val
	}
	if currentDeep > maxDeepDived {
		maxDeepDived = currentDeep
		sum = node.Val
	}

	if node.Left != nil {
		helper(currentDeep+1, node.Left)
	}
	if node.Right != nil {
		helper(currentDeep+1, node.Right)
	}

}
