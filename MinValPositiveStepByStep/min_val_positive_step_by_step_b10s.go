// https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
// https://play.golang.org/p/PkmPhoa0pu6
package main

import (
	"fmt"
	"math"
)

func main() {
	nums := []int{-3, 2, -3, 4, 2}
	fmt.Println(minStartValue(nums))
}

func minStartValue(nums []int) int {
	msv := 1
	sum := msv
	for _, v := range nums {
		sum += v
		if sum < 1 {
			msv += int(math.Abs(float64(1 - sum)))
			sum += int(math.Abs(float64(1 - sum)))
		}
	}
	return msv
}
