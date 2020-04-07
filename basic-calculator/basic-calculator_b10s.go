package main

import (
	"bufio"
	"fmt"
	"io"
	"math"
	"strconv"
	"strings"
)

func main() {
	s := "1*2+3*4-5*6+7*8-9*10"
	//s := "3/2"
	//s := "11 + 2*2"
	//s := "2-(5-6)"
	fmt.Println(calculate(s))
}

var (
	allowedOperators string = "+(*-)/"
)

// interface of SplitFunc: https://golang.org/pkg/bufio/#SplitFunc
func splitTokens(data []byte, atEOF bool) (advance int, token []byte, err error) {
	if idx := strings.IndexAny(string(data), allowedOperators); idx != -1 {
		// operand
		if idx > 0 {
			return idx, data[:idx], nil
		}
		// operator
		return 1, data[:1], nil
	}
	if atEOF {
		if len(data) == 0 {
			return 0, nil, io.EOF
		}
		return len(data), data, nil
	}
	return 0, nil, nil
}

type stack struct {
	data []string
}

func (s *stack) pop() (res string, isEmpty bool) {
	if len(s.data) == 0 {
		return "", true
	}
	res = s.data[len(s.data)-1]
	s.data = s.data[:len(s.data)-1]
	return res, false
}

func (s *stack) push(newEl string) {
	s.data = append(s.data, newEl)
}

func (s *stack) shift() (res string, isEmpty bool) {
	if len(s.data) == 0 {
		return "", true
	}
	res = s.data[0]
	s.data = s.data[1:]
	return res, false
}

type stackF struct {
	data []float64
}

func (s *stackF) pop() (res float64, isEmpty bool) {
	if len(s.data) == 0 {
		return -1, true
	}
	res = s.data[len(s.data)-1]
	s.data = s.data[:len(s.data)-1]
	return res, false
}

func (s *stackF) push(newEl float64) {
	s.data = append(s.data, newEl)
}

func operatorToCode(operator string) (code int) {
	switch operator {
	case "+", "-":
		code = 2
	case "*", "/":
		code = 3
	case "^":
		code = 4
	case "(":
		code = 5
		//case ")":
		//code = 5
	}
	return code
}

// with help of Dijkstra
// https://en.wikipedia.org/wiki/Shunting-yard_algorithm
func makePolandGreatAgain(s string) stack {
	// remove spaces
	s = strings.Replace(s, " ", "", -1)

	scanner := bufio.NewScanner(strings.NewReader(s))
	scanner.Split(splitTokens)

	poland := stack{[]string{}}
	operators := stack{[]string{}}

	// read a formula
	for scanner.Scan() {
		token := scanner.Text()
		// token is a number
		if strings.Index(allowedOperators, token) == -1 {
			poland.push(token)
			continue
		}
		// token is an operator
		nextOp := token
		if nextOp == ")" {
			// send all operators to poland :)
			for prevOp, isEmpty := operators.pop(); isEmpty || prevOp != "("; prevOp, isEmpty = operators.pop() {
				poland.push(prevOp)
			}
			continue
		}
		for {
			prevOp, isEmpty := operators.pop()
			if isEmpty {
				operators.push(nextOp)
				break
			}
			nextOpCode := operatorToCode(nextOp)
			prevOpCode := operatorToCode(prevOp)
			if nextOpCode > prevOpCode || prevOp == "(" {
				operators.push(prevOp)
				operators.push(nextOp)
				break
			} else {
				poland.push(prevOp)
			}
		}
	}
	// send other operators to poland
	for prevOp, isEmpty := operators.pop(); !isEmpty; prevOp, isEmpty = operators.pop() {
		poland.push(prevOp)
	}
	return poland
}

func calculate(s string) int {
	polandStack := makePolandGreatAgain(s)
	finalStack := stackF{[]float64{}}
	for token, empty := polandStack.shift(); !empty; token, empty = polandStack.shift() {
		operand, err := strconv.ParseFloat(token, 64)

		// token is a number
		if err == nil {
			finalStack.push(operand)
			continue
		}

		// token is an operator
		switch token {
		case "+":
			op2, _ := finalStack.pop()
			op1, _ := finalStack.pop()
			finalStack.push(op1 + op2)
		case "-":
			op2, _ := finalStack.pop()
			op1, _ := finalStack.pop()
			finalStack.push(op1 - op2)
		case "*":
			op2, _ := finalStack.pop()
			op1, _ := finalStack.pop()
			finalStack.push(op1 * op2)
		case "/":
			op2, _ := finalStack.pop()
			op1, _ := finalStack.pop()
			finalStack.push(float64(int(op1 / op2)))
		case "^":
			op2, _ := finalStack.pop()
			op1, _ := finalStack.pop()
			finalStack.push(math.Pow(op1, op2))
		}
	}

	res, _ := finalStack.pop()
	return int(res)
}
