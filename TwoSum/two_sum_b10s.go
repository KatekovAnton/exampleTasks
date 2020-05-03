// https://leetcode.com/problems/two-sum/
package main

import (
	"fmt"
)

func main() {
	//arr := []int{2, 3, 11, 15, 7}
	arr := make([]int, 1000000, 1000000)
	arr[999998] = 2
	arr[999999] = 7
	target := 9

	compl := map[int]int{}

	for i, v := range arr {
		if idx, ok := compl[target-v]; ok {
			fmt.Println(idx, i)
		}
		compl[v] = i
	}
}
