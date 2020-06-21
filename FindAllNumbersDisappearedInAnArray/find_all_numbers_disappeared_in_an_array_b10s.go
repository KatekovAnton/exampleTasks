package main

import (
	"fmt"
)

func main() {
	nums := []int{4, 3, 2, 7, 8, 2, 3, 1}
	nums = []int{1, 1}
	fmt.Println(findDisappearedNumbers(nums))

}

func findDisappearedNumbers(nums []int) []int {
	uniqNums := map[int]byte{}
	res := []int{}
	for _, x := range nums {
		uniqNums[x] = 1
	}
	for x := 1; x <= len(nums); x++ {
		if _, ok := uniqNums[x]; !ok {
			res = append(res, x)
		}
	}
	return res
}

// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
