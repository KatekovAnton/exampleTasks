package main

import (
	"fmt"
)

var buf map[int]int

func main() {
	n := 45
	buf = make(map[int]int)	
	res := helper(n)


	fmt.Println(res)
}



func helper(n int) (res int) {
	if v, ok := buf[n]; ok {
		return v
	}
	if n == 1 {
		return 1
	}
	if n == 2 {
		return 2
	}

	res += helper(n - 1)
	res += helper(n - 2)
	buf[n] = res
	return res
}

// https://leetcode.com/problems/climbing-stairs/
// https://play.golang.org/p/khmjnv2iu30
