package main

import (
	"fmt"
)

func main() {
	// test from the task
	//arr := []int{4, 5, 5, 4, 5} // 5
	//arr := []int{4, 2, 2, 4, 2} // 5
	//arr := []int{1, 2, 3, 2} // 3
	//arr := []int{0, 5, 4, 4, 5, 12} // 4
	//arr := []int{4, 4} // 2

	// test from anton
	arr := []int{0, 3, 3, 7, 3, 7, 3, 5, 3, 11, 1} // 6

	// test from b10s
	//arr := []int{1, 2, 1, 2, 3, 2, 3, 2} // 5

	if len(arr) < 2 {
		fmt.Println("an array must have 2 or more elements")
		return
	}

	left := arr[0]
	right := arr[1]
	count := 2
	precount := 1
	max := 0
	arr = arr[2:]

	for _, el := range arr {
		// debug
		//fmt.Printf("l: %v, r: %v, pc: %v, c: %v, el: %v\n", left, right, precount, count, el)
		if el == left {
			count++
			precount = 1
			left = right
			right = el
		} else if el == right {
			precount++
			count++
		} else {
			left = right
			right = el
			if count > max {
				max = count
			}
			count = precount + 1
		}
	}
	if count > max {
		max = count
	}
	fmt.Println(max)
}
