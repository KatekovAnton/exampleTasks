package main

import "fmt"

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func main() {
  t1 := &TreeNode{1, &TreeNode{3, &TreeNode{5, nil, nil}, nil}, &TreeNode{2, nil, nil}}
  t2 := &TreeNode{2, &TreeNode{1, nil, &TreeNode{4, nil, nil}}, &TreeNode{3, nil, &TreeNode{7, nil,nil}}}
	fmt.Printf("%V\n", mergeTrees(t1, t2))
}

func mergeTrees(t1 *TreeNode, t2 *TreeNode) *TreeNode {
	var x, y int
  var leftT1, rightT1, leftT2, rightT2 *TreeNode
  if t1 == nil && t2 == nil {
    return nil
  }
  if t1 != nil {
    x = t1.Val
    leftT1 = t1.Left
    rightT1 = t1.Right
  }
  if t2 != nil {
    y = t2.Val
    leftT2 = t2.Left
    rightT2 = t2.Right
  }

	return &TreeNode{x+y, mergeTrees(leftT1, leftT2), mergeTrees(rightT1, rightT2)}
}
