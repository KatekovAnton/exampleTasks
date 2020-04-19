package main

import (
    "fmt"
)

func sol(nums []int) int {
    if len(nums) == 1 {
        fmt.Println("arr has only one elelement")
        return nums[0]
    }
    if len(nums) == 2 {
        fmt.Println("arr has only two elelements")
        if nums[0] >= 0 && nums[1] >= 0 {
            return nums[0] + nums[1]
        }
        if nums[0] > nums[1] {
            return nums[0]
        }
        return nums[1]
    }

    sum, max, maxEl := nums[0], nums[0], nums[0]
    numsLen := len(nums) - 1
    for i := 1; i <= numsLen; i++ {
        // for case of all negative numbers
        if maxEl < nums[i] {
            maxEl = nums[i]
        }

        if sum < sum+nums[i] && sum < 0 {
            sum = nums[i]
        } else {
            sum += nums[i]
        }
        if sum > max {
            max = sum
        }
    }
    if max > maxEl {
        return max
    }
    return maxEl
}

func main() {
    // tests
    a := []int{-2, 1, -3, 4, -1, 2, 1, -5, 4} //6
    //a := []int{-2, 1} //1
    //a := []int{-2, -3, -1} // -1

    fmt.Println(a)

    fmt.Println(sol(a))
}
