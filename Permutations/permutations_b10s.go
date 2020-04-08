package main

import (
	"fmt"
)

func main() {
	nums := []int{1, 2, 3}
	fmt.Println(permute(nums))
}

func permute(nums []int) [][]int {
	res := [][]int{}
	helper([]int{}, nums, &res)
	return res
}

func helper(perm, nums []int, res *[][]int) {
	if len(nums) == 0 {
		*res = append(*res, perm)
		return
	}
	for i, _ := range nums {
		newnums := make([]int, len(nums))
		copy(newnums, nums)
		newnums = append(newnums[:i], newnums[i+1:]...)

		newperm := make([]int, len(perm))
		copy(newperm, perm)
		newperm = append(newperm, nums[i])

		helper(newperm, newnums, res)
	}
}
