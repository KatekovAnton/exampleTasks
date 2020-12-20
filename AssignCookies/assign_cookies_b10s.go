package main

import (
	"fmt"
	"sort"
)

func main() {
	g := []int{1, 2, 3}
	s := []int{1, 1}
	fmt.Println(findContentChildren(g, s))
}

func findContentChildren(g []int, s []int) int {
	res := 0
	sort.Sort(sort.Reverse(sort.IntSlice(g)))
	sort.Sort(sort.Reverse(sort.IntSlice(s)))

	i, j := 0, 0
	for {
		if i > (len(g)-1) || j > (len(s)-1) {
			break
		}
		if s[j] >= g[i] {
			res++
			i++
			j++
		} else {
			i++
		}
	}

	return res
}
