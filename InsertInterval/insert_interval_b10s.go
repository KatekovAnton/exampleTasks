package main

import (
	"fmt"
)

func min(x, y int) int {
	if x < y {
		return x
	}
	return y
}

func max(x, y int) int {
	if x > y {
		return x
	}
	return y
}

func main() {
	intervals := [][]int{[]int{2, 5}, []int{7, 9}}
	newInterval := []int{0, 1}
	newIntervals := insert(intervals, newInterval)
	fmt.Println(newIntervals)
}

func insert(intervals [][]int, newInterval []int) [][]int {
	newIntervals := [][]int{}
	s := newInterval[0]
	e := newInterval[1]
	f := true
	for _, i := range intervals {
		if !f {
			newIntervals = append(newIntervals, i)
			continue
		}
		fmt.Printf("s: %v, e: %v, i: %v\n", s, e, i)
		// edge case: interval is behind and not merged
		if i[0] > s && i[0] > e {
			newIntervals = append(newIntervals, newInterval)
			newIntervals = append(newIntervals, i)
			f = false
			continue
		}
		// edge case: new intervar is inside interval
		if i[0] <= s && i[1] >= e {
			newIntervals = append(newIntervals, i)
			f = false
			continue
		}

		if f && (i[0] >= s && i[0] <= e) || (i[1] >= s && i[1] <= e) {
			fmt.Printf("inside interval: %v\n", i)
			s = min(s, i[0])
			e = max(e, i[1])
			newInterval = []int{s, e}
		} else {
			newIntervals = append(newIntervals, i)
		}
	}
	if f {
		newIntervals = append(newIntervals, newInterval)
	}
	return newIntervals
}
