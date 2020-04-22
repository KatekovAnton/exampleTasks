package main

import (
	"fmt"
)

func main() {

	arr := [][]int{{0, 1, 0, 0},
		{1, 1, 1, 0},
		{0, 1, 0, 0},
		{1, 1, 0, 0}}
	orr := make([][]int, len(arr))
	for i := 0; i < len(arr); i++ {
		orr[i] = make([]int, len(arr[i]))
	}

	for i := 0; i < len(arr); i++ {
		for j := 0; j < len(arr[i]); j++ {
			if arr[i][j] == 1 {
				orr[i][j] += 4
				if i+1 < len(arr) {
					orr[i+1][j] -= 1
				}
				if i-1 >= 0 {
					orr[i-1][j] -= 1
				}
				if j+1 < len(orr[i]) {
					orr[i][j+1] -= 1
				}
				if j-1 >= 0 {
					orr[i][j-1] -= 1
				}
			}
		}
	}
	res := 0
	for i := 0; i < len(orr); i++ {
		for j:=0; j< len(orr[i]); j++ {
			if orr[i][j] > 0 {
				res += orr[i][j]
			}
		}
	}

	//fmt.Println(arr)
	//fmt.Println(orr)
	fmt.Println(res)
}

// https://leetcode.com/problems/island-perimeter
// https://play.golang.org/p/jSQlFQkrKxf
