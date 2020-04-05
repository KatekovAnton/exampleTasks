// from codility

public func solution1(_ array : inout [Int]) -> Int {
    
    if array.count < 3 {
        return array.count
    }
    
    var result = 2
    var sliceBegin = 0
    var sliceLength = 1
    var current1stValue = array[0]
    var current1sOffset = 1
    
    
    var elements = Set<Int>()
    elements.insert(current1stValue)
    
    var pointer = 1
    while pointer != array.count
    {
        let value = array[pointer]
        if !elements.contains(value)
        {
            if elements.count == 1 {
                elements.insert(value)
                
                
            }
            else {
                elements.remove(current1stValue)
                current1stValue = elements.first!
                elements.insert(value)
                var lastLength = sliceLength
                sliceLength = pointer - sliceBegin - current1sOffset
                sliceBegin += current1sOffset
                current1sOffset = lastLength - current1sOffset
            }
        }
        else {
            if current1stValue == value {
                current1sOffset = pointer - sliceBegin + 1
            }
            else {
                // nothing?
            }
        }
        sliceLength += 1;
        if sliceLength > result {
            result = sliceLength
        }
        
        pointer += 1
    }
    
    return result
}
