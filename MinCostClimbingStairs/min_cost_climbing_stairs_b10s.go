package main

import (
	"fmt"
)

func main() {
	//s := []int{10, 15, 20} // 15
	s := []int{1, 100, 1, 1, 1, 100, 1, 1, 100, 1} //6
	fmt.Println(minCostClimbingStairs(s))
}

func minCostClimbingStairs(cost []int) int {
	stairsLen := len(cost)
	climbedCost := make([]int, stairsLen)
	for i := 0; i <= stairsLen-1; i++ {
		costOne := cost[i]
		costTwo := cost[i]
		if i-1 >= 0 {
			costOne = cost[i] + climbedCost[i-1]
		}
		if i-2 >= 0 {
			costTwo = cost[i] + climbedCost[i-2]
		}
		if costOne < costTwo {
			climbedCost[i] = costOne
		} else {
			climbedCost[i] = costTwo
		}
	}

	if climbedCost[stairsLen-1] < climbedCost[stairsLen-2] {
		return climbedCost[stairsLen-1]
	}
	return climbedCost[stairsLen-2]
}

// https://leetcode.com/problems/min-cost-climbing-stairs
// https://play.golang.org/p/7NdfYqwJ-Hf
