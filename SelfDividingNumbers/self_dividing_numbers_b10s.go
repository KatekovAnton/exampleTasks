package main

import (
	"fmt"
)

func main() {
	x := 1
	y := 128
	fmt.Println(selfDividingNumbers(x, y))
}

func selfDividingNumbers(left int, right int) []int {
	res := []int{}
	for i := left; i <= right; i++ {
		num := i
		x := num
		f := true
		for {
			ost := x % 10
			if ost == 0 || num%ost != 0 {
				f = false
				break
			}
			x = x / 10
			if x == 0 {
				break
			}
		}
		if f {
			res = append(res, num)
		}
	}
	return res
}
