package main

import (
  "fmt"
  "strings"
 )

func main() {
  /*
  01
  12
  1223
  1223 2334
  1223 2334 2334 3445
  1223 2334 2334 3445 2334 3445 3445 4556
  1223 2334 2334 3445 2334 3445 3445 4556 2334 3445 3445 4556 3445 4556 4556 5667
  */
	num := 44
  fmt.Println(countBits_brute(num))
  fmt.Println(countBits(num))
}

func countBits_brute(num int) []int {
  res := []int{}
	for i := 0; i <= num; i++ {
    str := fmt.Sprintf("%b", i)
    cnt := strings.Count(str, "1")
    res = append(res, cnt)
	}
  return res
}

func countBits(num int) []int {
  res := []int{0}
	for i := 1; i <= num; i++ {
    res = append(res, res[i/2]+i%2)
	}
  return res
}
