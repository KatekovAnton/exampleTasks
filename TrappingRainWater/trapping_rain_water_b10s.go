package main

import "fmt"

func main() {
	in := []int{0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}
	fmt.Println(trap(in))
}

func trap(heights []int) int {
	buckets := []int{}
	bottoms := []int{}

	for _, height := range heights {

		// create new buckets
		for i := len(buckets); i < height; i++ {
			buckets = append(buckets, 0)
			bottoms = append(bottoms, 0)
		}

		for bucket := 0; bucket < len(buckets); bucket++ {
			if bucket+1 <= height {
				bottoms[bucket] = buckets[bucket]
			} else {
				buckets[bucket]++
			}
		}
	}

	var sum int
	for _, drops := range bottoms {
		sum += drops
	}

	return sum
}
