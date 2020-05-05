// https://leetcode.com/problems/valid-parentheses/
// https://play.golang.org/p/eZFNODxTgvO
package main

import (
	"fmt"
)

func main() {
	str := "{[]}"
	str = "{[[]]}"
	fmt.Println(isValid(str))

}

func isValid(s string) bool {
	st := []rune{}
	pairs := map[rune]rune{
		'}': '{',
		']': '[',
		')': '(',
	}

	for _, r := range s {
		if len(st) == 0 {
			st = append(st, r)
			continue
		}

		lastIdx := len(st) - 1
		if st[lastIdx] == pairs[r] {
			st = st[:lastIdx]
			continue
		}

		st = append(st, r)
	}
	if len(st) == 0 {
		return true
	}
	return false
}
